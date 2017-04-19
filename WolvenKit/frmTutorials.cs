using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WolvenKit.Properties;

namespace WolvenKit
{
    public partial class frmTutorials : Form
    {
        public static readonly List<Tutorial> Tutorials = new List<Tutorial>
        {
            new Tutorial("Traderain","Welcome page!",Resources.aERVQbx_460s,"<html><body><h3>Please select a tutorial from the side!<h3><br/></body></html>"),
            new Tutorial("KNG","Example",Resources.geralt,"<html><body><h3>This is an example<h3><br/></body></html>")
        }; 
        public frmTutorials()
        {
            InitializeComponent();
            webBrowser1.DocumentText = "<html><body><h3>Please select a tutorial from the side!<h3><br/>" +
    "</body></html>";
            treeView1.Nodes.Clear();
            Tutorials.ForEach(x=> treeView1.Nodes.Add(new TreeNode(x.title)));

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           var selectedtutorial = Tutorials.FirstOrDefault(x => x.title == e.Node.Text);
            pictureBox1.Image = selectedtutorial.picture;
            label2.Text = selectedtutorial.title;
            label3.Text = selectedtutorial.name;
            webBrowser1.DocumentText = selectedtutorial.tutorial;
        }
    }

    public class Tutorial
    {
        public string name;
        public string title;
        public Bitmap picture;
        public string tutorial;

        public Tutorial(string creatorname, string tutorialtitle, Bitmap tutorialpicture, string tutorialwebtext)
        {
            name = creatorname;
            title = tutorialtitle;
            picture = tutorialpicture;
            tutorial = tutorialwebtext;
        }
    }
}
