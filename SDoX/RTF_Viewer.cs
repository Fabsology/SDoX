using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDoX
{
    public partial class RTF_Viewer : MaterialForm
    {
        public string content = "";
        public RTF_Viewer()
        {
            InitializeComponent(); var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Amber800, Accent.Red400, TextShade.WHITE);
        }

        private void RTF_Viewer_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = content;
        }
    }
}
