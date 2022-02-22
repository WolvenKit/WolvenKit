using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.Functionality.Commands;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class Sector
    {
        public string Name { get; set; }
        public CName DepotPath { get; set; }
        public bool IsLoaded { get; set; }
        public Element3D Text { get; set; }
        public Element3D Element { get; set; }
        public uint NumberOfHandles { get; set; }

        private bool _showElements;
        public bool ShowElements
        {
            get => _showElements;
            set
            {
                _showElements = value;
                Element.IsRendering = _showElements;
            }
        }
    }

    public class WKBillboardTextModel3D : BillboardTextModel3D
    {
        public string MaterialName { get; set; }
        public string AppearanceName { get; set; }
    }

    public partial class RDTMeshViewModel
    {
        public List<Sector> Sectors { get; set; } = new();

        public ICommand LoadSectorCommand => new DelegateCommand<Sector>(x => LoadSector(x));
        public void LoadSector(Sector sector)
        {
            if (!sector.IsLoaded)
            {
                var sectorFile = File.GetFileFromDepotPathOrCache(sector.DepotPath);

                if (sectorFile.RootChunk is worldStreamingSector wss)
                {
                    sector.Element = RenderSector(wss, Appearances[0]);
                    sector.Element.Name = sector.Name.Replace("-", "n");
                    sector.IsLoaded = true;
                    sector.ShowElements = true;
                    sector.Text.IsRendering = false;
                }
            }
        }

        public RDTMeshViewModel(worldStreamingBlock data, RedDocumentViewModel file) : this(file)
        {
            _data = data;
            Header = "Sector Previews";

            var app = new Appearance()
            {
                Name = "All_Sectors",
            };

            Appearances.Add(app);
            SelectedAppearance = app;

            var texts = new GroupModel3D()
            {
                Name = "SectorNames"
            };

            var sectors = new List<Sector>();

            var exterior = new GroupModel3D()
            {
                Name = "Exterior"
            };
            var interior = new GroupModel3D()
            {
                Name = "Interior"
            };
            var quest = new GroupModel3D()
            {
                Name = "Quest"
            };
            var navigation = new GroupModel3D()
            {
                Name = "Navigation"
            };
            var other = new GroupModel3D()
            {
                Name = "Other"
            };

            foreach (var desc in data.Descriptors)
            {
                var text = new BillboardText3D();
                text.TextInfo.Add(
                    new TextInfo(Path.GetFileNameWithoutExtension(desc.Data.DepotPath.ToString()),
                    new SharpDX.Vector3((desc.StreamingBox.Max.X + desc.StreamingBox.Min.X) / 2, (desc.StreamingBox.Max.Z + desc.StreamingBox.Min.Z) / 2, -(desc.StreamingBox.Max.Y + desc.StreamingBox.Min.Y) / 2))
                    {
                        Foreground = SharpDX.Color.Red,
                        Scale = 1f
                    }
                );
                var bbText = new WKBillboardTextModel3D()
                {
                    Geometry = text,
                    Name = Path.GetFileNameWithoutExtension(desc.Data.DepotPath.ToString()).Replace("-", "n")
                };
                if (desc.Category.Value == Enums.worldStreamingSectorCategory.Exterior)
                {
                    exterior.Children.Add(bbText);
                }
                else if (desc.Category.Value == Enums.worldStreamingSectorCategory.Interior)
                {
                    interior.Children.Add(bbText);
                }
                else if (desc.Category.Value == Enums.worldStreamingSectorCategory.Quest)
                {
                    quest.Children.Add(bbText);
                }
                else if (desc.Category.Value == Enums.worldStreamingSectorCategory.Navigation)
                {
                    navigation.Children.Add(bbText);
                }
                else
                {
                    other.Children.Add(bbText);
                }
                sectors.Add(new Sector()
                {
                    Name = Path.GetFileNameWithoutExtension(desc.Data.DepotPath.ToString()),
                    DepotPath = desc.Data.DepotPath,
                    Text = bbText,
                    NumberOfHandles = desc.NumNodeRanges
                });
            }
            Sectors = new List<Sector>(sectors.OrderBy(x => x.Name).ToList());
            texts.Children.Add(exterior);
            texts.Children.Add(interior);
            texts.Children.Add(quest);
            texts.Children.Add(navigation);
            texts.Children.Add(other);
            app.ModelGroup.Add(texts);

        }

        public void OnMouseDown3DHandler(object sender, MouseDown3DEventArgs e)
        {
            if (e.HitTestResult != null && ((MouseButtonEventArgs)e.OriginalInputEventArgs).LeftButton == MouseButtonState.Pressed)
            {
                if (e.HitTestResult.ModelHit is WKBillboardTextModel3D text)
                {
                    var sector = Sectors.Where(x => x.Text == text).FirstOrDefault();
                    if (sector != null)
                    {
                        LoadSector(sector);
                    }
                    e.Handled = true;
                }
                if (e.HitTestResult.ModelHit is MeshComponent group)
                {
                    SelectedItem = group;
                    e.Handled = true;
                }
            }
        }
    }
}
