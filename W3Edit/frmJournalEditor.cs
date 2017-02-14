using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W;
using W3Edit.CR2W.Types;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmJournalEditor : DockContent
    {
        private CR2WFile file;

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
                    var creaturename = typenode.GetVariableByName("baseName");
                    indeximage_label.Text = typenode.GetVariableByName("image").ToString();
                    this.Text = $@"Creature editor [{creaturename}]";
                    descriptiontext += (creaturename + "\n\n");
                    ParseUsedAgainst((CArray)typenode.GetVariableByName("itemsUsedAgainstCreature"));
                    ParseCJournalCreatureChildren((CArray)typenode.GetVariableByName("children"));
                    break;
                }
                case "CJournalCharacter":
                {
                    var creaturename = typenode.GetVariableByName("baseName");
                    indeximage_label.Text = typenode.GetVariableByName("image").ToString();
                    this.Text = $@"Character editor [{creaturename}]";
                    descriptiontext += (creaturename + "\n\n");
                    vulnerable_treview.Hide();
                    ParseCJournalCharacterChildren((CArray)typenode.GetVariableByName("children"));
                    break;
                }
                case "CJournalGlossary":
                {
                    var creaturename = typenode.GetVariableByName("baseName");
                    this.Text = $@"Glossary editor [{creaturename}]";
                    descriptiontext += (creaturename + "\n\n");
                    vulnerable_treview.Hide();
                    ParseCJournalGlossaryChildren((CArray)typenode.GetVariableByName("children"));
                    break;
                }
                case "CJournalTutorial":
                {
                    var creaturename = typenode.GetVariableByName("baseName");
                    indeximage_label.Text = creaturename.ToString();
                    descriptiontext += typenode.GetVariableByName("description").ToString();
                    vulnerable_treview.Hide();
                    this.Text = $@"Tutorial editor [{creaturename}]";
                    break;
                }
                case "CJournalStoryBookChapter":
                    {
                        var creaturename = typenode.GetVariableByName("baseName");
                        indeximage_label.Text = creaturename.ToString();
                        vulnerable_treview.Hide();
                        this.Text = $@"Tutorial editor [{creaturename}]";
                        break;
                    }
                default:
                {
                    vulnerable_treview.Hide();
                    var creaturename = typenode.GetVariableByName("baseName");
                    indeximage_label.Text = creaturename.ToString();
                    this.Text = $@"{typenode.Type} editor [{creaturename}]";
                    break;
                }
            }

        }


        #region CJournalCreature
        public void ParseUsedAgainst(CArray infos)
        {
            descriptionRenderer.DocumentText += ("Items used against:\n");
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


        public void RenderDescription(string text)
        {
            descriptionRenderer.Navigate("about:blank");
            descriptionRenderer.Document?.OpenNew(false);
            descriptionRenderer.Document?.Write(($"<html><body>{text}</body></html>"));
            descriptionRenderer.Refresh();
        }
    }
}
