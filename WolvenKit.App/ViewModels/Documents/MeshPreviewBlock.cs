using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows.Input;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using Prism.Commands;
using ReactiveUI;
using Splat;
using WolvenKit.Core.Interfaces;
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

        public Vector3 SearchPoint { get; set; } = new();

        public bool SearchActive = false;

        public ICommand LoadSectorCommand => new DelegateCommand<Sector>(x => LoadSector(x));
        public void LoadSector(Sector sector)
        {
            if (!sector.IsLoaded)
            {
                var sectorFile = File.GetFileFromDepotPathOrCache(sector.DepotPath);

                if (sectorFile is not null && sectorFile.RootChunk is worldStreamingSector wss)
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

            SearchForPointCommand = new DelegateCommand(ExecuteSearchForPoint);
            ClearSearchCommand = new DelegateCommand(ExecuteClearSearch);

            this.WhenActivated((CompositeDisposable disposables) => RenderBlockSolo());
        }

        public ICommand ClearSearchCommand { get; set; }
        public void ExecuteClearSearch()
        {
            SearchActive = false;
            RenderBlock((worldStreamingBlock)_data);
        }

        public ICommand SearchForPointCommand { get; set; }
        public void ExecuteSearchForPoint()
        {
            SearchActive = true;
            RenderBlock((worldStreamingBlock)_data);
        }

        public void RenderBlockSolo()
        {
            if (IsRendered)
            {
                return;
            }
            IsRendered = true;
            RenderBlock((worldStreamingBlock)_data);
        }

        public void RenderBlock(worldStreamingBlock data)
        {
            Appearances = new();

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
            var exterior_0 = new GroupModel3D()
            {
                Name = "Exterior_0"
            };
            var exterior_1 = new GroupModel3D()
            {
                Name = "Exterior_1"
            };
            var exterior_2 = new GroupModel3D()
            {
                Name = "Exterior_2"
            };
            var exterior_3 = new GroupModel3D()
            {
                Name = "Exterior_3"
            };
            var exterior_4 = new GroupModel3D()
            {
                Name = "Exterior_4"
            };
            var exterior_5 = new GroupModel3D()
            {
                Name = "Exterior_5"
            };
            var exterior_6 = new GroupModel3D()
            {
                Name = "Exterior_6"
            };
            exterior.Children.Add(exterior_0);
            exterior.Children.Add(exterior_1);
            exterior.Children.Add(exterior_2);
            exterior.Children.Add(exterior_3);
            exterior.Children.Add(exterior_4);
            exterior.Children.Add(exterior_5);
            exterior.Children.Add(exterior_6);
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
                if (!SearchActive || (SearchPoint.X < desc.StreamingBox.Max.X && SearchPoint.X > desc.StreamingBox.Min.X &&
                    SearchPoint.Y < desc.StreamingBox.Max.Y && SearchPoint.Y > desc.StreamingBox.Min.Y &&
                    SearchPoint.Z < desc.StreamingBox.Max.Z && SearchPoint.Z > desc.StreamingBox.Min.Z))
                {
                    var text = new BillboardText3D();
                    text.TextInfo.Add(
                        new TextInfo(Path.GetFileNameWithoutExtension(desc.Data.DepotPath.ToString()),
                        new SharpDX.Vector3((desc.StreamingBox.Max.X + desc.StreamingBox.Min.X) / 2, (desc.StreamingBox.Max.Z + desc.StreamingBox.Min.Z) / 2, -(desc.StreamingBox.Max.Y + desc.StreamingBox.Min.Y) / 2))
                        {
                            Foreground = SharpDX.Color.Red,
                            Scale = 0.5f
                        }
                    );

                    var bbText = new WKBillboardTextModel3D()
                    {
                        Geometry = text,
                        Name = Path.GetFileNameWithoutExtension(desc.Data.DepotPath.ToString()).Replace("-", "n")
                    };

                    if (desc.Category == Enums.worldStreamingSectorCategory.Exterior)
                    {
                        //var mb = new MeshBuilder();

                        //mb.AddBox(text.TextInfo[0].Origin,
                        //    desc.StreamingBox.Max.X - desc.StreamingBox.Min.X,
                        //    desc.StreamingBox.Max.Y - desc.StreamingBox.Min.Y,
                        //    desc.StreamingBox.Max.Z - desc.StreamingBox.Min.Z);
                        //mb.ComputeNormalsAndTangents(MeshFaces.Default);

                        //var material = SetupPBRMaterial("DefaultMaterial");
                        //material.AlbedoColor = new SharpDX.Color4(1f, 1f, 1f, 0.01f);

                        //var mesh = new MeshGeometryModel3D()
                        //{
                        //    Geometry = mb.ToMeshGeometry3D(),
                        //    Material = material,
                        //    IsTransparent = true
                        //};

                        if (desc.Level == 0)
                        {
                            exterior_0.Children.Add(bbText);
                            //exterior_0.Children.Add(mesh);
                        }
                        else if (desc.Level == 1)
                        {
                            exterior_1.Children.Add(bbText);
                            //exterior_1.Children.Add(mesh);
                        }
                        else if (desc.Level == 2)
                        {
                            exterior_2.Children.Add(bbText);
                            //exterior_2.Children.Add(mesh);
                        }
                        else if (desc.Level == 3)
                        {
                            exterior_3.Children.Add(bbText);
                            //exterior_3.Children.Add(mesh);
                        }
                        else if (desc.Level == 4)
                        {
                            exterior_4.Children.Add(bbText);
                            //exterior_4.Children.Add(mesh);
                        }
                        else if (desc.Level == 5)
                        {
                            exterior_5.Children.Add(bbText);
                            //exterior_5.Children.Add(mesh);
                        }
                        else if (desc.Level == 6)
                        {
                            exterior_6.Children.Add(bbText);
                            //exterior_6.Children.Add(mesh);
                        }
                        else
                        {
                            exterior.Children.Add(bbText);
                            //exterior.Children.Add(mesh);
                        }


                    }
                    else if (desc.Category == Enums.worldStreamingSectorCategory.Interior)
                    {
                        interior.Children.Add(bbText);
                    }
                    else if (desc.Category == Enums.worldStreamingSectorCategory.Quest)
                    {
                        quest.Children.Add(bbText);
                    }
                    else if (desc.Category == Enums.worldStreamingSectorCategory.Navigation)
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
            if (e.HitTestResult is not null && ((MouseButtonEventArgs)e.OriginalInputEventArgs).LeftButton == MouseButtonState.Pressed)
            {
                if (e.HitTestResult.ModelHit is WKBillboardTextModel3D text)
                {
                    var sector = Sectors.Where(x => x.Text == text).FirstOrDefault();
                    if (sector is not null)
                    {
                        try
                        {
                            LoadSector(sector);
                        }
                        catch (Exception ex)
                        {
                            Locator.Current.GetService<ILoggerService>().Error(ex);
                        }
                    }
                    e.Handled = true;
                }
                if (e.HitTestResult.ModelHit is MeshComponent group)
                {
                    SelectedItem = group;
                    e.Handled = true;
                }
                if (e.HitTestResult.ModelHit is SubmeshComponent lod)
                {
                    var instance = lod.Parent as MeshComponent;
                    var mesh = instance.Parent as MeshComponent;
                    Locator.Current.GetService<ILoggerService>().Info("Mesh Name: " + mesh.Name);
                }
            }
        }
    }
}
