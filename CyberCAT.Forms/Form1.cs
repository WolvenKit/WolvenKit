using System.ComponentModel;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Save;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace CyberCAT.Forms
{
    public partial class Form1 : Form
    {
        private HashService _hashService;
        private TweakDBService _tweakDbService;

        private CyberpunkSaveFile _save;

        public Form1()
        {
            InitializeComponent();

            _hashService = new HashService();
            _tweakDbService = new TweakDBService();

            TypeDescriptor.AddAttributes(typeof(InventoryHelper.ItemData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(InventoryHelper.HeaderThing), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(InventoryHelper.ItemModData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(InventoryHelper.IItemData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(InventoryHelper.SimpleItemData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(InventoryHelper.ModableItemData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(InventoryHelper.ModableItemWithQuantityData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IParseableBuffer), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(RedPackage), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(RedBaseClass), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            var path = SaveHelper.GetSavePath("ManualSave-2093");
            if (path != null)
            {
                using var ms = new MemoryStream(File.ReadAllBytes(path));
                var reader = new CyberpunkSaveReader(ms);

                if (reader.ReadFile(out var save) == EFileReadErrorCodes.NoError)
                {
                    _save = save!;
                    GenerateTreeView();
                }
            }
        }

        private void GenerateTreeView()
        {
            treeView1.Nodes.Clear();

            foreach (var node in _save.Nodes)
            {
                AddNode(node);
            }

            void AddNode(NodeEntry saveNode, TreeNode? parentTreeNode = null)
            {
                var name = saveNode.Name;
                if (saveNode.Value is InventoryHelper.ItemData itemData)
                {
                    if (!string.IsNullOrEmpty(itemData.ItemTdbId.ResolvedText))
                    {
                        name = itemData.ItemTdbId.ResolvedText;
                    }
                    else
                    {
                        name = itemData.ItemTdbId.ToString();
                    }
                }

                var node = new TreeNode($"[{saveNode.Id}] {name}")
                {
                    Tag = saveNode
                };
                foreach (var child in saveNode.Children)
                {
                    AddNode(child, node);
                }

                if (parentTreeNode == null)
                {
                    treeView1.Nodes.Add(node);
                }
                else
                {
                    parentTreeNode.Nodes.Add(node);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is NodeEntry nodeEntry)
            {
                propertyGrid1.SelectedObject = nodeEntry.Value;
            }
        }
    }
}
