using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using W3SavegameEditor.Core.Savegame;
using W3SavegameEditor.Core.Savegame.Variables;
using W3SavegameEditor.Core.SaveModels;

namespace WolvenKit
{
    public partial class frmSaveEditor : Form
    {
        public frmSaveEditor()
        {
            InitializeComponent();
            Savegames = new List<SavegameModel>();
            UpdateSaves();
            UpdateSaveTree(Savegames);
        }

        public static List<SavegameModel> Savegames { get; set; }

        public void UpdateSaves()
        {
            Savegames.Clear();
            var gamesavesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "The Witcher 3\\gamesaves");
            var filesPaths = Directory.GetFiles(gamesavesPath, "*.sav");

            foreach (var filePath in filesPaths)
            {
                var thumbnailFilePath = Path.Combine(Path.GetDirectoryName(filePath) ?? "",
                    Path.GetFileNameWithoutExtension(filePath) + ".png");

                Savegames.Add(new SavegameModel
                {
                    Name = Path.GetFileName(filePath),
                    Path = filePath,
                    ThumbnailPath = thumbnailFilePath
                });
            }
        }

        public void UpdateSaveTree(List<SavegameModel> Savegames)
        {
            savesTree.Nodes.Clear();
            foreach (var save in Savegames)
            {
                var node = new TreeNode(save.Name);
                savesTree.Nodes.Add(node);
            }
        }

        private void savesTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                var save = Savegames.FirstOrDefault(x => x.Name == e.Node.Text);
                var parsedsave = SavegameFile.Read(save.Path);
                saveNameBox.Text = save.Name;
                saveIcon.BackgroundImage = new Bitmap(save.ThumbnailPath);
                saveVersionBox.Text = parsedsave.TypeCode1 + "." + parsedsave.TypeCode2 + "." + parsedsave.TypeCode3;
                saveNamesBox.Text = parsedsave.VariableNames.Count().ToString();
                saveVariableBox.Text = parsedsave.Variables.Count().ToString();
                variablesList.Items.Clear();
                foreach (var node in parsedsave.Variables.Select(ToVariableModel).ToList())
                {
                    var variablenode = new ListViewItem();
                    variablenode.Text = node.Index.ToString();
                    variablenode.SubItems.Add(node.Name);
                    variablenode.SubItems.Add(node.Type);
                    variablenode.SubItems.Add(node.Value == "" ? "NONE" : node.Value);
                    variablenode.SubItems.Add(node.DebugString);
                    variablenode.SubItems.Add(node.Children.Count().ToString());
                    variablesList.Items.Add(variablenode);
                }
            }
            catch
            {
            }
        }

        private static VariableModel ToVariableModel(Variable v, int i)
        {
            var set = v as VariableSet;
            var children = set == null
                ? new ObservableCollection<VariableModel>()
                : new ObservableCollection<VariableModel>(set.Variables.Select(ToVariableModel));

            var typed = v as TypedVariable;
            var type = typed == null
                ? "None"
                : typed.Type;

            var value = typed == null || typed.Value == null
                ? ""
                : typed.Value.ToString();

            return new VariableModel
            {
                Index = i,
                Name = v == null ? "" : v.Name,
                Type = type,
                Value = value,
                DebugString = v == null ? "" : v.ToString(),
                Children = children
            };
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save explorer v0.1\nBased on:https://github.com/Atvaark/W3SavegameEditor ", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}