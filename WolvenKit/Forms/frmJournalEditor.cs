using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Model;
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
            var basenode = File.Chunks[0];
            CJournalResource journalResource = basenode.data as CJournalResource;

            if (File != null && File.Chunks.Count > 0)
            {
                switch (basenode.REDType)
                {
                    case "CJournalResource":
                        //ParseJournalType((CPtr)File.chunks[0].GetVariableByName("entry"));
                        ParseJournalType(journalResource.Entry);
                        break;
                    default:
                        break;
                }
            }

        }

        public void ParseImageAndPreview(CJournalCreature creature)
        {
            var image = creature.Image.REDValue;
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

        public void ParseImageAndPreview(CJournalCharacter character)
        {
            var image = character.Image.REDValue;
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

        public void ParseJournalType(CPtr<CJournalBase> pointer)
        {
            CR2WExportWrapper typenode = pointer.Reference;
            CVariable target = typenode.data;

            if (target is CJournalCreature creature)
            {
                vulnerable_treview.Show();
                var name = creature.BaseName;
                this.Text = $@"Creature editor [{name}]";
                descriptiontext += (name + "<br>");
                ParseUsedAgainst(creature.ItemsUsedAgainstCreature);
                ParseImageAndPreview(creature);
                ParseCJournalCreatureChildren(creature.Children);
            }
            else if (target is CJournalCharacter character)
            {
                var name = character.BaseName;
                ParseImageAndPreview(character);
                this.Text = $@"Character editor [{name}]";
                descriptiontext += (name + "<br>");
                vulnerable_treview.Hide();
                ParseChildDescription(character.Children);
            }
            else if (target is CJournalGlossary)
            {
                var name = (target as CJournalGlossary).BaseName;
                this.Text = $@"Glossary editor [{name}]";
                descriptiontext += (name + "<br>");
                vulnerable_treview.Hide();
                ParseChildDescription((target as CJournalGlossary).Children);
            }
            else if (target is CJournalTutorial)
            {
                var name = (target as CJournalTutorial).BaseName;
                descriptiontext += (target as CJournalTutorial).Description.ToString();
                vulnerable_treview.Hide();
                entityImage.Hide();
                this.Text = $@"Tutorial editor [{name}]";
            }
            else if (target is CJournalStoryBookChapter)
            {
                var name = (target as CJournalStoryBookChapter).BaseName;
                vulnerable_treview.Hide();
                entityImage.Hide();
                this.Text = $@"Story book editor [{name}]";
            }
            else if (target is CJournalStoryBookPage)
            {
                var name = (target as CJournalStoryBookPage).BaseName;
                descriptiontext += "<h3>" + (target as CJournalStoryBookPage).Title + "</h3>";
                ParseChildDescription((target as CJournalStoryBookPage).Children);
                vulnerable_treview.Hide();
                entityImage.Hide();
                this.Text = $@"Story book editor [{name}]";
            }
            else if (target is CJournalQuest)
            {
                textRender.Hide();
                vulnerable_treview.Hide();
                QuestView = new TreeView();
                splitContainer1.Panel2.Controls.Add(QuestView);
                QuestView.Dock = DockStyle.Fill;
                var name = (target as CJournalQuest).Title + " " + (target as CJournalQuest).Type;
                this.Text = $@"Quest editor [{name}]";
                ParseCJournalQuestChild((target as CJournalQuest).Children);
            }
            else
            {
                vulnerable_treview.Hide();
                var name = (target as CJournalBase).BaseName;
                this.Text = $@"{typenode.REDType} editor [{name}]";
            }
        }


        #region CJournalCreature
        public void ParseUsedAgainst<T>(CArray<T> infos) where T : CVariable
        {
            foreach (var info in infos.Elements)
            {
                vulnerable_treview.Nodes.Add(info.ToString());
            }
        }

        public void ParseCJournalCreatureChildren(CArray<CPtr<CJournalContainerEntry>> childs)
        {
            foreach (CPtr<CJournalContainerEntry> child in childs.Elements)
            {
                if (child.Reference.data is CJournalCreatureDescriptionGroup)
                {
                    ParseCJournalCreatureDescriptionGroupChildren((child.Reference.data as CJournalCreatureDescriptionGroup).Children);
                }
            }
        }

        public void ParseCJournalCreatureDescriptionGroupChildren(CArray<CPtr<CJournalContainerEntry>> childs)
        {
            foreach (CPtr<CJournalContainerEntry> child in childs.Elements)
            {

                if (child.Reference.data is CJournalCreatureDescriptionEntry)
                {
                    descriptiontext += ("\n\n" + (child.Reference.data as CJournalCreatureDescriptionEntry).Description.ToString() + "\n");
                }
            }
        }
        #endregion

        #region Common

        public void ParseChildDescription(CArray<CPtr<CJournalContainerEntry>> childs)
        {
            foreach (var child in childs.Elements)
            {
                switch (child.Reference.REDType)
                {
                    case "CJournalGlossaryDescription":
                        {
                            descriptiontext += (child.Reference.data as CJournalGlossaryDescription).Description + "<br>";
                            break;
                        }
                    case "CJournalCharacterDescription":
                        {
                            descriptiontext += (child.Reference.data as CJournalCharacterDescription).Description + "<br>";
                            break;
                        }
                    case "CJournalStoryBookPageDescription":
                        {
                            descriptiontext += (child.Reference.data as CJournalStoryBookPageDescription).Description + "<br>";
                            break;
                        }
                }
            }
        }
        #endregion

        #region CJournalQuest

        public void ParseCJournalQuestChild(CArray<CPtr<CJournalContainerEntry>> childs)
        {
            foreach (var child in childs.Elements)
            {
                switch (child.Reference.REDType)
                {
                    case "CJournalQuestDescriptionGroup":
                        {
                            ParseCJournalQuestDescriptionGroupChild((child.Reference.data as CJournalQuestDescriptionGroup).Children);
                            break;
                        }
                    case "CJournalQuestPhase":
                        {
                            ParseCJournalQuestPhaseChild((child.Reference.data as CJournalQuestPhase).Children);
                            break;
                        }
                }
            }
        }

        public void ParseCJournalQuestDescriptionGroupChild<T>(CArray<CPtr<T>> childs) where T : CVariable
        {
            foreach (var child in childs.Elements)
            {
                switch (child.Reference.REDType)
                {
                    case "CJournalQuestDescriptionEntry":
                        {
                            var questnode = new TreeNode((child.Reference.data as CJournalQuestDescriptionEntry).BaseName.ToString());
                            questnode.Nodes.Add(new TreeNode((child.Reference.data as CJournalQuestDescriptionEntry).Description.ToString()));
                            //QuestView.Nodes.Add(questnode);
                            break;
                        }
                }
            }
        }

        public void ParseCJournalQuestPhaseChild<T>(CArray<CPtr<T>> childs) where T : CVariable
        {
            foreach (var child in childs.Elements)
            {
                switch (child.Reference.REDType)
                {
                    case "CJournalQuestObjective":
                        {
                            var questnode = new TreeNode((child.Reference.data as CJournalQuestObjective).BaseName.ToString());
                            questnode.Nodes.Add(new TreeNode((child.Reference.data as CJournalQuestObjective).Title.ToString()));
                            if ((child.Reference.data as CJournalQuestObjective).Children != null)
                            {
                                if ((child.Reference.data as CJournalQuestObjective).Children.Elements.Count > 0)
                                {
                                    var detailnode = ParseCJournalQuestObjectiveChild((child.Reference.data as CJournalQuestObjective).Children);
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

        public TreeNode ParseCJournalQuestObjectiveChild<T>(CArray<CPtr<T>> childs) where T : CVariable
        {
            var result = new TreeNode("Details");
            foreach (var child in childs.Elements)
            {
                switch (child.Reference.REDType)
                {
                    case "CJournalQuestMapPin":
                        {
                            var pinnode = new TreeNode("Map pin");
                            pinnode.Nodes.Add(new TreeNode("Name: " + (child as CJournalQuestMapPin).MapPinID));
                            pinnode.Nodes.Add(new TreeNode("Radius: " + (child as CJournalQuestMapPin).Radius));
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
