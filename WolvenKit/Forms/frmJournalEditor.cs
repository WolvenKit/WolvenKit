using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.Cache;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Render;

namespace WolvenKit
{
    public partial class frmJournalEditor : DockContent
    {
        private CR2WFile file;

        private TreeView QuestView;

        public string descriptiontext;

        public frmJournalEditor()
        {
            InitializeComponent();
        }

        public CR2WFile File
        {
            get { return file; }
            set
            {
                file = value;
                ParseJournal();
                RenderDescription(descriptiontext);
            }
        }

        public void ParseJournal()
        {
            var basenode = File.chunks[0];

            if (File != null && File.chunks.Count > 0)
            {
                switch (basenode.Type)
                {
                    case "CJournalResource":
                        ParseJournalType((CPtr)File.chunks[0].GetVariableByName("entry"));
                        break;
                    default:
                        break;
                }
            }

        }

        public void ParseImageAndPreview(CR2WExportWrapper chunk)
        {
            var image = chunk.GetVariableByName("image").ToString();
            if (!string.IsNullOrEmpty(image))
            {
                try
                {
                    var files = MainController.ImportFile(image, MainController.Get().TextureManager);
                    entityImage.Image = ImageUtility.FromBytes(files[0]);
                    entimgbox.Image = ImageUtility.FromBytes(files[1]);
                }
                catch
                {
                    //TODO: Log
                }
            }
        }

        public void ParseJournalType(CPtr pointer)
        {
            var typenode = pointer.Reference;
            switch (pointer.GetPtrTargetType())
            {
                case "CJournalCreature":
                {
                    vulnerable_treview.Show();
                    var name = typenode.GetVariableByName("baseName");
                    this.Text = $@"Creature editor [{name}]";
                    descriptiontext += (name + "<br>");
                    ParseUsedAgainst((CArray)typenode.GetVariableByName("itemsUsedAgainstCreature"));
                    ParseImageAndPreview(typenode);
                    ParseCJournalCreatureChildren((CArray)typenode.GetVariableByName("children"));
                    break;
                }
                case "CJournalCharacter":
                {
                    var name = typenode.GetVariableByName("baseName");
                    ParseImageAndPreview(typenode);
                    this.Text = $@"Character editor [{name}]";
                    descriptiontext += (name + "<br>");
                    vulnerable_treview.Hide();
                    ParseChildDescription((CArray)typenode.GetVariableByName("children"));
                    break;
                }
                case "CJournalGlossary":
                {
                    var name = typenode.GetVariableByName("baseName");
                    this.Text = $@"Glossary editor [{name}]";
                    descriptiontext += (name + "<br>");
                    vulnerable_treview.Hide();
                    ParseChildDescription((CArray)typenode.GetVariableByName("children"));
                    break;
                }
                case "CJournalTutorial":
                {
                    var name = typenode.GetVariableByName("baseName");
                    descriptiontext += typenode.GetVariableByName("description").ToString();
                    vulnerable_treview.Hide();
                    entityImage.Hide();
                    this.Text = $@"Tutorial editor [{name}]";
                    break;
                }
                case "CJournalStoryBookChapter":
                {
                    var name = typenode.GetVariableByName("baseName");
                    vulnerable_treview.Hide();
                    entityImage.Hide();
                    this.Text = $@"Story book editor [{name}]";
                    break;
                }
                case "CJournalStoryBookPage":
                {
                   var name = typenode.GetVariableByName("baseName");
                   descriptiontext += "<h3>" + typenode.GetVariableByName("title") + "</h3>";
                   ParseChildDescription((CArray)typenode.GetVariableByName("children"));
                   vulnerable_treview.Hide();
                   entityImage.Hide();
                   this.Text = $@"Story book editor [{name}]";
                   break;
                }
                case "CJournalQuest":
                {
                    textRender.Hide();
                    vulnerable_treview.Hide();
                    QuestView = new TreeView();
                    splitContainer1.Panel2.Controls.Add(QuestView);
                    QuestView.Dock = DockStyle.Fill;
                    var name = typenode.GetVariableByName("title") + " " + typenode.GetVariableByName("type");
                    this.Text = $@"Quest editor [{name}]";
                    ParseCJournalQuestChild((CArray) typenode.GetVariableByName("children"));
                    break;
                }
                default:
                {
                    vulnerable_treview.Hide();
                    var name = typenode.GetVariableByName("baseName");
                    this.Text = $@"{typenode.Type} editor [{name}]";
                    break;
                }
            }

        }


        #region CJournalCreature
        public void ParseUsedAgainst(CArray infos)
        {
            foreach (var info in infos)
            {
                vulnerable_treview.Nodes.Add(info.ToString());
            }
        }

        public void ParseCJournalCreatureChildren(CArray childs)
        {
            foreach (CPtr child in childs )
            {
                switch (child.Reference.Type)
                {
                    case "CJournalCreatureDescriptionGroup":
                    {
                        ParseCJournalCreatureDescriptionGroupChildren((CArray)child.Reference.GetVariableByName("children"));
                        break;
                    }
                }
            }
        }

        public void ParseCJournalCreatureDescriptionGroupChildren(CArray childs)
        {
            foreach (CPtr child in childs)
            {
                switch (child.Reference.Type)
                {
                    case "CJournalCreatureDescriptionEntry":
                        {
                            descriptiontext += ("\n\n" +child.Reference.GetVariableByName("description") + "\n");
                            break;
                        }
                }
            }
        }
        #endregion

        #region Common

        public void ParseChildDescription(CArray childs)
        {
            foreach (var cVariable in childs)
            {
                var child = (CPtr) cVariable;
                switch (child.Reference.Type)
                {
                    case "CJournalGlossaryDescription":
                    {
                        descriptiontext += child.Reference.GetVariableByName("description") + "<br>";
                            break;
                    }
                    case "CJournalCharacterDescription":
                    {
                        descriptiontext += child.Reference.GetVariableByName("description") + "<br>";
                            break;
                    }
                    case "CJournalStoryBookPageDescription":
                    {
                        descriptiontext += child.Reference.GetVariableByName("description") + "<br>";
                        break;
                    }
                }
            }
        }
        #endregion

        #region CJournalQuest

        public void ParseCJournalQuestChild(CArray childs)
        {
            foreach (var cVariable in childs)
            {
                var child = (CPtr)cVariable;
                switch (child.Reference.Type)
                {
                    case "CJournalQuestDescriptionGroup":
                        {
                            ParseCJournalQuestDescriptionGroupChild((CArray)child.Reference.GetVariableByName("children"));
                            break;
                        }
                    case "CJournalQuestPhase":
                        {
                            ParseCJournalQuestPhaseChild((CArray)child.Reference.GetVariableByName("children"));
                            break;
                        }
                }
            }
        }

        public void ParseCJournalQuestDescriptionGroupChild(CArray childs)
        {
            foreach (var cVariable in childs)
            {
                var child = (CPtr)cVariable;
                switch (child.Reference.Type)
                {
                    case "CJournalQuestDescriptionEntry":
                    {
                        var questnode = new TreeNode(child.Reference.GetVariableByName("baseName").ToString());
                        questnode.Nodes.Add(new TreeNode(child.Reference.GetVariableByName("description").ToString()));
                        //QuestView.Nodes.Add(questnode);
                        break;
                    }
                }
            }
        }

        public void ParseCJournalQuestPhaseChild(CArray childs)
        {
            foreach (var cVariable in childs)
            {
                var child = (CPtr)cVariable;
                switch (child.Reference.Type)
                {
                    case "CJournalQuestObjective":
                        {
                            var questnode = new TreeNode(child.Reference.GetVariableByName("baseName").ToString());
                            questnode.Nodes.Add(new TreeNode(child.Reference.GetVariableByName("title").ToString()));
                            if (child.Reference.GetVariableByName("children") != null)
                            {
                                if (((CArray) child.Reference.GetVariableByName("children")).array.Count > 0)
                                {
                                    var detailnode = ParseCJournalQuestObjectiveChild((CArray)child.Reference.GetVariableByName("children"));
                                    if (detailnode.Nodes.Count != 0)
                                    {
                                        questnode.Nodes.Add(detailnode);
                                    }
                                }
                            }
                            QuestView.Nodes.Add(questnode);
                            break;
                        }
                }
            }
        }

        public TreeNode ParseCJournalQuestObjectiveChild(CArray childs)
        {
            var result = new TreeNode("Details");
            foreach (var child in childs.Cast<CPtr>())
            {
                switch (child.Reference.Type)
                {
                    case "CJournalQuestMapPin":
                    {
                        var pinnode = new TreeNode("Map pin");
                        pinnode.Nodes.Add(new TreeNode("Name: " + child.Reference.GetVariableByName("mapPinID")));
                        pinnode.Nodes.Add(new TreeNode("Radius: " + child.Reference.GetVariableByName("radius")));
                        result.Nodes.Add(pinnode);
                        break;
                    }
                }
            }
            return result;
        }
        #endregion

        public void RenderDescription(string text)
        {
            var webBrowser = new WebBrowser();
            webBrowser.CreateControl(); // only if needed
            webBrowser.DocumentText = ($"<html><body>{text}</body></html>");
            Application.DoEvents();
            webBrowser.Document.ExecCommand("SelectAll", false, null);
            webBrowser.Document.ExecCommand("Copy", false, null);
            textRender.Paste();
        }  
    }
}
