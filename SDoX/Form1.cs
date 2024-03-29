﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.rtf.parser;
using MaterialSkin;
using MaterialSkin.Controls;
using PuppeteerSharp;
using RtfPipe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public static bool loading = false;
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

            EditorContentBox.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1031{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}\r\n{\\colortbl ;\\red255\\green192\\blue0;\\red255\\green255\\blue255;\\red165\\green165\\blue165;\\red51\\green51\\blue51;}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\pard\\cf1\\highlight2\\f0\\fs47 My Fancy Headline\\cf0\\fs17\\line\\line\\cf3\\fs20 My Fancy Introduction About The Document\\cf0\\line\\line\\cf4 My Fance Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.\\cf0\\highlight0\\par\r\n}\r\n";
            EditorAuthorBox.Text = "Your, the Author";
            EditorTitleBox.Text = "New Document";
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
            FileTitle.Text = System.IO.Path.GetFileName(SdoXPath);
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {
                materialCheckBox1.Location = new System.Drawing.Point(40, 7);
                deleteButton.Enabled = true;
                deleteButton.Visible = true;
            }
            else
            {
                materialCheckBox1.Location = new System.Drawing.Point(110, 7);
                deleteButton.Enabled = false;
                deleteButton.Visible = false;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            materialCheckBox1.Checked = false;
            deleteButton.Enabled = false;
            deleteButton.Visible = false;


            var result = from r in this.Documents where r.Title.ToLower() == documentationTitle.Text.ToLower() select r;
            try
            {
                this.Documents.Remove(result.First());
                saveDocumentationInFile();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An Error occurred while saving!\n\n" + Ex.Message, "Oopsy!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void searchbar_TextChanged(object sender, EventArgs e)
        {

            documentationListView.Items.Clear();
            foreach (SDoXDocument document in this.Documents)
            {
                if (document.Title.ToLower().Contains(searchbar.Text.ToLower()) || document.Content.ToLower().Contains(searchbar.Text.ToLower()) || document.Author.ToLower().Contains(searchbar.Text.ToLower()) || document.Description.ToLower().Contains(searchbar.Text.ToLower()))
                {
                    string[] row = { document.Title, document.Description, document.Author };
                    ListViewItem ListEntry = new ListViewItem(row);
                    documentationListView.Items.Add(ListEntry);
                }
            }
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save As PDF";
            sfd.Filter = "(*.pdf)|*.pdf";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            if (sfd.ShowDialog() == DialogResult.OK)
            {


                /*
                iTextSharp.text.Document DOC = new iTextSharp.text.Document();
                PdfWriter.GetInstance(DOC, new FileStream(sfd.FileName, FileMode.Create))
                DOC.Open();
                foreach (SDoXDocument document in this.Documents)
                {
                    if (document.Title.ToLower() == documentationTitle.Text.ToLower())
                    {

                        DOC.AddTitle(document.Title);
                        DOC.AddAuthor(document.Author);
                        RichTextBox temprtb = new RichTextBox();
                        temprtb.Rtf = document.Content;
                        DOC.Add(new iTextSharp.text.Paragraph(temprtb.Text));
                        break;
                    }
                }
                DOC.Close();
                DOC.Dispose();
                */
                Convert2PDF(sfd.FileName);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            RTF_Viewer rTF = new RTF_Viewer();
            rTF.content = EditorContentBox.Rtf;
            rTF.ShowDialog();
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            EditorContentBox.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1031{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}\r\n{\\colortbl ;\\red255\\green192\\blue0;\\red255\\green255\\blue255;\\red165\\green165\\blue165;\\red51\\green51\\blue51;}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\pard\\cf1\\highlight2\\f0\\fs47 My Fancy Headline\\cf0\\fs17\\line\\line\\cf3\\fs20 My Fancy Introduction About The Document\\cf0\\line\\line\\cf4 My Fance Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.\\cf0\\highlight0\\par\r\n}\r\n";
            EditorAuthorBox.Text = "Your, the Author";
            EditorTitleBox.Text = "New Document";

        }

        public void Convert2PDF(string FILENAME)
        {

            loading = true;
            string rtfText = DocumentationViewBox.Rtf; // RTF-Inhalt aus Ihrem Editor-Feld
            rtfText = Rtf.ToHtml(rtfText);
            ConvertRTF2PDF(rtfText,FILENAME);
            /*
            string rtfhtml = "";
            // Create a new document
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(FILENAME, FileMode.Create));
            document.Open();

            // Create a MemoryStream from the RTF text
            MemoryStream stream = new MemoryStream();
            StreamWriter streamWriter = new StreamWriter(stream);
            streamWriter.Write(rtfText);
            streamWriter.Flush();
            stream.Position = 0;

            // Create an instance of RtfParser
            RtfParser parser = new RtfParser(null);

            // Read the RTF data from the MemoryStream and convert it to PDF
            parser.ConvertRtfDocument(new StreamReader(stream).BaseStream, document);

            document.Close();

            */
            Console.WriteLine("PDF created successfully!");
        }



        static async Task ConvertRTF2PDF(string RTF_Content, string FILENAME)
        {
            var rtfContent = RTF_Content; // RTF-Inhalt einlesen
            var pdfFilePath = FILENAME; // Zielpdf-Datei

            await ConvertRtfToPdfAsync(rtfContent, pdfFilePath);

            Console.WriteLine("RTF erfolgreich in PDF mit Formatierung konvertiert.");
        }


        static async Task ConvertRtfToPdfAsync(string rtfContent, string pdfFilePath)
        {
            try
            {
                await new BrowserFetcher().DownloadAsync(); // Chrome herunterladen

                var launchOptions = new LaunchOptions
                {
                    Headless = true
                };

                using (var browser = await Puppeteer.LaunchAsync(launchOptions))
                using (var page = await browser.NewPageAsync())
                {
                    // Konvertiere RTF-Text in PDF mit Formatierung
                    await page.SetContentAsync(rtfContent);
                    await page.PdfAsync(pdfFilePath);
                }
                loading = false;
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                loading = false;
                MessageBox.Show("Fehler beim Konvertieren von RTF in PDF: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(loading)
            {
                this.Enabled = false;
                this.Text = "Loading...";
            } else
            {
                this.Enabled = true;
                this.Text = "SDoX";
            }
        }
    }
}
