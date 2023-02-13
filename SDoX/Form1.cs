using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SDoX
{
    public partial class Form1 : MaterialForm
    {

        public List<SDoXDocument> Documents = new List<SDoXDocument>();
        public string SdoXPath = "SDoX.SDoX";
        public Form1()
        {
            InitializeComponent();

            documentationListView.Columns.Add("Title", 200);
            documentationListView.Columns.Add("Description", 200);
            documentationListView.Columns.Add("Author", 200);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Amber800, Accent.Red400, TextShade.WHITE);
        
        
        }   

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SDoXDocument document = new SDoXDocument(EditorTitleBox.Text, EditorAuthorBox.Text, EditorContentBox.RichTextBox.Rtf, EditorDescriptionBox.Text);
            foreach (SDoXDocument listDocument in this.Documents)
            {
                if (this.Documents.Count() > 0 && listDocument.Title == document.Title)
                {
                    DialogResult dialogResult = MessageBox.Show("Would you like to override the existing Document?", "This Document seem to exists already!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Save in Documents
                        var result = from r in this.Documents where r.Title == listDocument.Title select r;
                        result.First().setContent(EditorContentBox.RichTextBox.Rtf);
                        result.First().setDescription(EditorDescriptionBox.Text);
                        refreshListview();
                        return;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            this.Documents.Add(document);
            refreshListview();
            saveDocumentationInFile();
        }

        private void saveDocumentationInFile()
        {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(SdoXPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                formatter.Serialize(stream, this.Documents);
                stream.Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            refreshListview();
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            documentationListView.Items.Clear();
            foreach (SDoXDocument document in this.Documents)
            {
                if (document.Title.ToLower().Contains(searchbar.Text.ToLower()) || document.Author.ToLower().Contains(searchbar.Text.ToLower()) || document.Description.ToLower().Contains(searchbar.Text.ToLower()))
                {
                    string[] row = { document.Title, document.Description, document.Author };
                    ListViewItem ListEntry = new ListViewItem(row);
                    documentationListView.Items.Add(ListEntry);
                }

            }
        }

        private void refreshListview()
        {

            documentationListView.Items.Clear();
            foreach (SDoXDocument document in this.Documents)
            {
                string[] row = { document.Title, document.Description, document.Author };
                ListViewItem ListEntry = new ListViewItem(row);

                documentationListView.Items.Add(ListEntry);
            }
            documentationListView.Update();
        }

        private void documentationListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            openDocumentation();
        }
        private void openDocumentation()
        {
            if (documentationListView.SelectedItems[0].Text != "")
            {
                foreach (SDoXDocument document in this.Documents)
                {
                    if (document.Title == documentationListView.SelectedItems[0].Text)
                    {
                        documentationTitle.Text = document.Title.ToUpper();
                        DocumentationViewBox.Rtf = document.Content;
                        AuthorLabel.Text = "Author: " + document.Author;
                        DocumentLastUpdated.Text = "Last Updated: " + document.DateCreated.ToShortDateString();
                        DocumentCreated.Text = "Created: " + document.DateUpdated.ToShortDateString();

                    }
                }
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {

            foreach (SDoXDocument document in this.Documents)
            {
                if (document.Title.ToLower() == documentationTitle.Text.ToLower())
                {
                    EditorDescriptionBox.Text = document.Description;
                    EditorTitleBox.Text = document.Title;
                    EditorAuthorBox.Text = document.Author;
                    EditorContentBox.Rtf = document.Content;
                    break;
                }
            }
            tabControl1.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);

            string[] args = Environment.GetCommandLineArgs();
            SdoXPath = args.Length > 1 ? args[1] : "SDoX.SDoX";
            openFile();
        }

        public void openFile()
        {

            if (System.IO.File.Exists(SdoXPath))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(SdoXPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                try
                {
                    this.Documents = (List<SDoXDocument>)formatter.Deserialize(stream);
                }
                catch (Exception Ex)
                {
                    DialogResult dialogResult = MessageBox.Show("The Documentation seem to be corrupted! Check your 'SDoX.SDoX' file in your local installation folder! \nErrM:\n" + Ex.Message, "Serialization Error", MessageBoxButtons.OK);
                }
                stream.Close();
            }
            refreshListview();
            tabControl1.SelectedIndex = 2;
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {
                materialCheckBox1.Location = new Point(40, 7);
                deleteButton.Enabled = true;
                deleteButton.Visible = true;
            } else
            {
                materialCheckBox1.Location = new Point(110, 7);
                deleteButton.Enabled = false;
                deleteButton.Visible = false;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            materialCheckBox1.Checked = false;
            deleteButton.Enabled = false;
            deleteButton.Visible = false;


            var result = from r in this.Documents where r.Title == documentationTitle.Text select r;
            try { 
                this.Documents.Remove(result.First());
                saveDocumentationInFile();
            } catch (Exception Ex)
            {

            }
            documentationTitle.Text = "";
            DocumentCreated.Text = "Created:";
            DocumentLastUpdated.Text = "Last Updated:";
            AuthorLabel.Text = "Author:";
            DocumentationViewBox.Text = "";
            refreshListview();
            tabControl1.SelectedIndex = 3;
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SdoXPath = saveFileDialog1.FileName;
            saveDocumentationInFile();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SdoXPath = openFileDialog1.FileName;
            openFile();
        }
    }
}
