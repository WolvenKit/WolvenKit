using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

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

        public void ParseJournalType(CPtr pointer)
        {
            var typenode = pointer.PtrTarget;
            switch (pointer.PtrTargetType)
            {
                case "CJournalCreature":
                {
                    vulnerable_treview.Show();
                    var name = typenode.GetVariableByName("baseName");
                    indeximage_label.Text = typenode.GetVariableByName("image").ToString();
                    this.Text = $@"Creature editor [{name}]";
                    descriptiontext += (name + "\n\n");
                    ParseUsedAgainst((CArray)typenode.GetVariableByName("itemsUsedAgainstCreature"));
                    ParseCJournalCreatureChildren((CArray)typenode.GetVariableByName("children"));
                    break;
                }
                case "CJournalCharacter":
                {
                    var name = typenode.GetVariableByName("baseName");
                    indeximage_label.Text = typenode.GetVariableByName("image").ToString();
                    this.Text = $@"Character editor [{name}]";
                    descriptiontext += (name + "\n\n");
                    vulnerable_treview.Hide();
                    ParseCJournalCharacterChildren((CArray)typenode.GetVariableByName("children"));
                    break;
                }
                case "CJournalGlossary":
                {
                    var name = typenode.GetVariableByName("baseName");
                    this.Text = $@"Glossary editor [{name}]";
                    descriptiontext += (name + "\n\n");
                    vulnerable_treview.Hide();
                    ParseCJournalGlossaryChildren((CArray)typenode.GetVariableByName("children"));
                    break;
                }
                case "CJournalTutorial":
                {
                    var name = typenode.GetVariableByName("baseName");
                    indeximage_label.Text = name.ToString();
                    descriptiontext += typenode.GetVariableByName("description").ToString();
                    vulnerable_treview.Hide();
                    this.Text = $@"Tutorial editor [{name}]";
                    break;
                }
                case "CJournalStoryBookChapter":
                {
                    var name = typenode.GetVariableByName("baseName");
                    indeximage_label.Text = name.ToString();
                    vulnerable_treview.Hide();
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
                    indeximage_label.Text = name;
                    this.Text = $@"Quest editor [{name}]";
                    ParseCJournalQuestChild((CArray) typenode.GetVariableByName("children"));
                    break;
                }
                default:
                {
                    vulnerable_treview.Hide();
                    var name = typenode.GetVariableByName("baseName");
                    indeximage_label.Text = name.ToString();
                    this.Text = $@"{typenode.Type} editor [{name}]";
                    break;
                }
            }

        }


        #region CJournalCreature
        public void ParseUsedAgainst(CArray infos)
        {
            textRender.Text += ("Items used against:\n");
            foreach (var info in infos)
            {
                vulnerable_treview.Nodes.Add(info.ToString());
            }
        }

        public void ParseCJournalCreatureChildren(CArray childs)
        {
            foreach (CPtr child in childs )
            {
                switch (child.PtrTarget.Type)
                {
                    case "CJournalCreatureDescriptionGroup":
                    {
                        ParseCJournalCreatureDescriptionGroupChildren((CArray)child.PtrTarget.GetVariableByName("children"));
                        break;
                    }
                }
            }
        }

        public void ParseCJournalCreatureDescriptionGroupChildren(CArray childs)
        {
            foreach (CPtr child in childs)
            {
                switch (child.PtrTarget.Type)
                {
                    case "CJournalCreatureDescriptionEntry":
                        {
                            descriptiontext += ("\n\n" +child.PtrTarget.GetVariableByName("description") + "\n");
                            break;
                        }
                }
            }
        }
        #endregion

        #region CJournalCharacter
        public void ParseCJournalCharacterChildren(CArray childs)
        {
            foreach (CPtr child in childs)
            {
                switch (child.PtrTarget.Type)
                {
                    case "CJournalCharacterDescription":
                    {
                        descriptiontext += child.PtrTarget.GetVariableByName("description");
                        break;
                    }
                }
            }
        }
        #endregion

        #region CJournalGlossary

        public void ParseCJournalGlossaryChildren(CArray childs)
        {
            foreach (var cVariable in childs)
            {
                var child = (CPtr) cVariable;
                switch (child.PtrTarget.Type)
                {
                    case "CJournalGlossaryDescription":
                    {
                        descriptiontext += child.PtrTarget.GetVariableByName("description");
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
                switch (child.PtrTarget.Type)
                {
                    case "CJournalQuestDescriptionGroup":
                        {
                            ParseCJournalQuestDescriptionGroupChild((CArray)child.PtrTarget.GetVariableByName("children"));
                            break;
                        }
                    case "CJournalQuestPhase":
                        {
                            ParseCJournalQuestPhaseChild((CArray)child.PtrTarget.GetVariableByName("children"));
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
                switch (child.PtrTarget.Type)
                {
                    case "CJournalQuestDescriptionEntry":
                    {
                        var questnode = new TreeNode(child.PtrTarget.GetVariableByName("baseName").ToString());
                        questnode.Nodes.Add(new TreeNode(child.PtrTarget.GetVariableByName("description").ToString()));
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
                switch (child.PtrTarget.Type)
                {
                    case "CJournalQuestObjective":
                        {
                            var questnode = new TreeNode(child.PtrTarget.GetVariableByName("baseName").ToString());
                            questnode.Nodes.Add(new TreeNode(child.PtrTarget.GetVariableByName("title").ToString()));
                            if (child.PtrTarget.GetVariableByName("children") != null)
                            {
                                if (((CArray) child.PtrTarget.GetVariableByName("children")).array.Count > 0)
                                {
                                    var detailnode = ParseCJournalQuestObjectiveChild((CArray)child.PtrTarget.GetVariableByName("children"));
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
                switch (child.PtrTarget.Type)
                {
                    case "CJournalQuestMapPin":
                    {
                        var pinnode = new TreeNode("Map pin");
                        pinnode.Nodes.Add(new TreeNode("Name: " + child.PtrTarget.GetVariableByName("mapPinID")));
                        pinnode.Nodes.Add(new TreeNode("Radius: " + child.PtrTarget.GetVariableByName("radius")));
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
