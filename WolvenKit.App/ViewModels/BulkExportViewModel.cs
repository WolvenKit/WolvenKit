using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Render;
using WolvenKit.App.Model;
using IrrlichtLime.Video;
using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using IrrlichtLime;

namespace WolvenKit.App.ViewModels
{
    public class BulkExportViewModel : ViewModel
    {
        private class MeshPart
        {
            public WKMesh Mesh { get; set; }
            public IrrlichtLime.Core.Matrix Transform { get; set; }
        };

        public BulkExportViewModel()
        {
            Logger = MainController.Get().Logger;
            RunCommand = new RelayCommand(Run, CanRun);
            ProgressReport = new ProgressReport();


        }

        public event EventHandler PerformStep;
        protected void OnPerformStepRequest() => this.PerformStep?.Invoke(this, new EventArgs());
        public event EventHandler Reset;
        protected void OnResetRequest() => this.Reset?.Invoke(this, new EventArgs());

        #region Fields
        private /*readonly*/ LoggerService Logger;

        #endregion

        #region Properties
        public String InputPath { get; set; }
        public String ExportPath { get; set; }
        public String GeometryType { get; set; }
        public String TextureType { get; set; }
        public bool MergeMeshes { get; set; }

        #region ProgressReport
        private ProgressReport _progressReport;
        public ProgressReport ProgressReport
        {
            get => _progressReport;
            set
            {
                if (_progressReport != value)
                {
                    _progressReport = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #endregion

        #region Commands
        public ICommand RunCommand { get; }

        #endregion

        #region Commands Implementation
        protected bool CanRun()
        {
            return true;
        }

        protected async void Run()
        {
            await Task.Run(() => RunBulkExportInternal());
        }

        #endregion

        #region Methods
        public async Task<int> RunBulkExportInternal()
        {
            string[] files = Directory.GetFiles(InputPath, "*.w2l", SearchOption.AllDirectories);

            Logger.LogString($"Starting Bulk export. Found {files.Length} files to export. \r\n", Logtype.Normal);
            ProgressReport.Max = files.Length;
            ProgressReport.Min = 0;
            ProgressReport.Value = 0;

            OnResetRequest();

            int currentFile = 0;
            foreach (var path in files)
            {
                ++currentFile;
                Logger.LogString($"[{currentFile}/{files.Length}] {path}\r\n", Logtype.Normal);

                CR2WFile cr2w;
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                {
                    cr2w = new CR2WFile();
                    cr2w.Read(reader);
                    fs.Close();
                }

                await Task.Run(() => ExportMeshAsync(path, cr2w))
                    .ContinueWith(antecedent =>
                    {
                        OnPerformStepRequest();
                    });
            }
            Logger.LogString($"Completed.\r\n", Logtype.Success);
            return 0;
        }

        private string GetColorAsStringLine(IrrlichtLime.Video.Color color)
        {
            string line;
            double val = (double)color.Red / 255.0;
            line = val.ToString();
            line += " ";
            val = (double)color.Green / 255.0;
            line += val.ToString();
            line += " ";
            val = (double)color.Blue / 255.0;
            line += val.ToString();
            line += "\n";

            return line;
        }

        private void WriteMeshesAsObj(string path, List<MeshPart> meshParts)
        {
            // create material file
            string matFile = path;
            matFile = matFile.Replace(".obj", ".mtl");

            string texExtension = "." + TextureType;

            List<Material> mat = new List<Material>();

            using (var writer = new StreamWriter(path))
            {
                writer.Write("# exported by WolvenKit\n");
                writer.Write("mtllib ");
                writer.Write(Path.GetFileName(matFile));
                writer.Write("\n\n");

                uint allVertexCount = 1;
                foreach (MeshPart mp in meshParts)
                {
                    WKMesh mesh = mp.Mesh;
                    var localToWorld = mp.Transform;

                    for (int i = 0; i < mesh.CData.staticMesh.MeshBufferCount; ++i)
                    {
                        int num = i + 1;

                        MeshBuffer mb = mesh.CData.staticMesh.MeshBuffers[i];
                        if (mb.VertexCount > 0)
                        {
                            writer.Write("g grp");
                            writer.Write(num.ToString());
                            writer.Write("\n");

                            for (int j = 0; j < mb.VertexCount; ++j)
                            {
                                Vector3Df v = new Vector3Df(mb.GetPosition(j));
                                localToWorld.TransformVector(ref v);

                                writer.Write("v ");
                                string s = v.X.ToString() + " " + v.Y.ToString() + " " + v.Z.ToString() + "\n";
                                writer.Write(s);
                            }

                            for (int j = 0; j < mb.VertexCount; ++j)
                            {
                                Vector2Df uv = new Vector2Df(mb.GetTCoords(j));
                                uv.Y = 1.0f - uv.Y;
                                writer.Write("vt ");
                                string s = uv.X.ToString() + " " + uv.Y.ToString() + "\n";
                                writer.Write(s);
                            }

                            for (int j = 0; j < mb.VertexCount; ++j)
                            {
                                Vector3Df v = mb.GetNormal(j);
                                writer.Write("vn ");
                                string s = v.X.ToString() + " " + v.Y.ToString() + " " + v.Z.ToString() + "\n";
                                writer.Write(s);
                            }

                            writer.Write("usemtl mat");
                            string numStr = "";

                            for (int j = 0; j < mat.Count; ++j)
                            {
                                if (mat[j] == mb.Material)
                                {
                                    numStr = j.ToString();
                                    break;
                                }
                            }

                            if (numStr == "")
                            {
                                numStr = mat.Count.ToString();
                                mat.Add(mb.Material);
                            }

                            writer.Write(numStr);
                            writer.Write("\n");

                            UInt16[] indices = (UInt16[])mb.Indices;
                            for (int j = 0; j < mb.IndexCount; j += 3)
                            {
                                writer.Write("f ");
                                uint n = indices[j + 2] + allVertexCount;
                                writer.Write(n.ToString() + "/" + n.ToString() + "/" + n.ToString() + " ");

                                n = indices[j + 1] + allVertexCount;
                                writer.Write(n.ToString() + "/" + n.ToString() + "/" + n.ToString() + " ");

                                n = indices[j] + allVertexCount;
                                writer.Write(n.ToString() + "/" + n.ToString() + "/" + n.ToString() + "\n");
                            }

                            writer.Write("\n");
                            allVertexCount += (uint)mb.VertexCount;
                        }

                    }
                }
                writer.Flush();
                writer.Close();
            }

            using (var writer = new StreamWriter(matFile))
            {
                writer.Write("# exported by WolvenKit\n\n");
                for (int i = 0; i < mat.Count; ++i)
                {
                    writer.Write("newmtl mat");
                    writer.Write(i.ToString());
                    writer.Write("\n");

                    writer.Write("Ka " + GetColorAsStringLine(mat[i].AmbientColor));
                    writer.Write("Kd " + GetColorAsStringLine(mat[i].DiffuseColor));
                    writer.Write("Ks " + GetColorAsStringLine(mat[i].SpecularColor));
                    writer.Write("Ke " + GetColorAsStringLine(mat[i].EmissiveColor));

                    double s = mat[i].Shininess / 0.128;
                    writer.Write("Ns " + s.ToString() + "\n");

                    if (mat[i].GetTexture(0) != null)
                    {
                        writer.Write("map_Kd ");
                        IrrlichtLime.Core.Matrix m = mat[i].GetTextureMatrix(0);

                        float tx = m.GetElement(8);
                        float ty = m.GetElement(9);
                        //m.GetTextureTranslate(out tx, out ty);

                        if (tx != 0 || ty != 0)
                        {
                            writer.Write("-o ");
                            writer.Write(tx.ToString());
                            writer.Write(" ");
                            writer.Write(ty.ToString());
                            writer.Write(" ");
                        }

                        float sx = m.GetElement(0);
                        float sy = m.GetElement(5);
                        //m.GetTextureScale(out sx, out sy);

                        if (sx != 1.0f || sy != 1.0f)
                        {
                            writer.Write("-s ");
                            writer.Write(sx.ToString());
                            writer.Write(" ");
                            writer.Write(sy.ToString());
                            writer.Write(" ");
                        }

                        string tname = mat[i].GetTexture(0).Name.ToString();
                        tname = tname.Replace(".xbm", texExtension);
                        writer.Write(Path.GetFileName(tname));
                        writer.Write("\n");
                    }
                    if (mat[i].GetTexture(1) != null)
                    {
                        // normal map
                        writer.Write("map_Bump ");
                        string tname = mat[i].GetTexture(1).Name.ToString();
                        tname = tname.Replace(".xbm", texExtension);
                        writer.Write(Path.GetFileName(tname));
                        writer.Write("\n");
                    }
                    writer.Write("\n");
                }
                writer.Flush();
                writer.Close();
            }
        }

        private void WriteMeshAsObj(string path, string meshPath, WKMesh mesh, IrrlichtLime.Core.Matrix localToWorld)
        {
            // create material file
            string matFile = path;
            matFile = matFile.Replace(".obj", ".mtl");
            string texExtension = "." + TextureType;

            List<Material> mat = new List<Material>();

            using (var writer = new StreamWriter(path))
            {
                writer.Write("# exported by WolvenKit\n");
                writer.Write("# ");
                writer.Write(meshPath);
                writer.Write("\nmtllib ");
                writer.Write(Path.GetFileName(matFile));
                writer.Write("\n\n");

                uint allVertexCount = 1;
                for (int i = 0; i < mesh.CData.staticMesh.MeshBufferCount; ++i)
                {
                    int num = i + 1;

                    MeshBuffer mb = mesh.CData.staticMesh.MeshBuffers[i];
                    if (mb.VertexCount > 0)
                    {
                        writer.Write("g grp");
                        writer.Write(num.ToString());
                        writer.Write("\n");

                        for (int j = 0; j < mb.VertexCount; ++j)
                        {
                            Vector3Df v = new Vector3Df(mb.GetPosition(j));                            
                            localToWorld.TransformVector(ref v);

                            writer.Write("v ");
                            string s = v.X.ToString() + " " + v.Y.ToString() + " " + v.Z.ToString() + "\n";
                            writer.Write(s);
                        }

                        for (int j = 0; j < mb.VertexCount; ++j)
                        {
                            Vector2Df uv = new Vector2Df(mb.GetTCoords(j));
                            uv.Y = 1.0f - uv.Y;
                            writer.Write("vt ");
                            string s = uv.X.ToString() + " " + uv.Y.ToString() + "\n";
                            writer.Write(s);
                        }

                        
                        for (int j = 0; j < mb.VertexCount; ++j)
                        {
                            Vector3Df v = mb.GetNormal(j);
                            writer.Write("vn ");
                            string s = v.X.ToString() + " " + v.Y.ToString() + " " + v.Z.ToString() + "\n";
                            writer.Write(s);
                        }

                        writer.Write("usemtl mat");
                        string numStr = "";

                        for (int j = 0; j < mat.Count; ++j)
                        {
                            if (mat[j] == mb.Material)
                            {
                                numStr = j.ToString();
                                break;
                            }
                        }

                        if (numStr == "")
                        {
                            numStr = mat.Count.ToString();
                            mat.Add(mb.Material);
                        }

                        writer.Write(numStr);
                        writer.Write("\n");

                        UInt16[] indices = (UInt16[])mb.Indices;
                        for (int j = 0; j < mb.IndexCount; j += 3)
                        {
                            writer.Write("f ");
                            uint n = indices[j + 2] + allVertexCount;
                            writer.Write(n.ToString() + "/" + n.ToString() + "/" + n.ToString() + " ");

                            n = indices[j + 1] + allVertexCount;
                            writer.Write(n.ToString() + "/" + n.ToString() + "/" + n.ToString() + " ");

                            n = indices[j] + allVertexCount;
                            writer.Write(n.ToString() + "/" + n.ToString() + "/" + n.ToString() + "\n");
                        }

                        writer.Write("\n");
                        allVertexCount += (uint)mb.VertexCount;
                    }

                }

                writer.Flush();
                writer.Close();
            }

            using (var writer = new StreamWriter(matFile))
            {
                writer.Write("# exported by WolvenKit\n\n");
                for(int i=0; i < mat.Count; ++i)
                {
                    writer.Write("newmtl mat");
                    writer.Write(i.ToString());
                    writer.Write("\n");

                    writer.Write("Ka " + GetColorAsStringLine(mat[i].AmbientColor));
                    writer.Write("Kd " + GetColorAsStringLine(mat[i].DiffuseColor));
                    writer.Write("Ks " + GetColorAsStringLine(mat[i].SpecularColor));
                    writer.Write("Ke " + GetColorAsStringLine(mat[i].EmissiveColor));

                    double s = mat[i].Shininess / 0.128;
                    writer.Write("Ns " + s.ToString() + "\n");

                    if(mat[i].GetTexture(0) != null)
                    {
                        writer.Write("map_Kd ");
                        IrrlichtLime.Core.Matrix m = mat[i].GetTextureMatrix(0);

                        float tx = m.GetElement(8);
                        float ty = m.GetElement(9);
                        //m.GetTextureTranslate(out tx, out ty);

                        if (tx != 0 || ty != 0)
                        {
                            writer.Write("-o ");
                            writer.Write(tx.ToString());
                            writer.Write(" ");
                            writer.Write(ty.ToString());
                            writer.Write(" ");
                        }

                        float sx = m.GetElement(0);
                        float sy = m.GetElement(5);
                        //m.GetTextureScale(out sx, out sy);

                        if (sx != 1.0f || sy != 1.0f)
                        {
                            writer.Write("-s ");
                            writer.Write(sx.ToString());
                            writer.Write(" ");
                            writer.Write(sy.ToString());
                            writer.Write(" ");
                        }

                        string tname = mat[i].GetTexture(0).Name.ToString();
                        tname = tname.Replace(".xbm", texExtension);
                        writer.Write(Path.GetFileName(tname));
                        writer.Write("\n");
                    }
                    if (mat[i].GetTexture(1) != null)
                    {
                        // normal map
                        writer.Write("map_Bump ");
                        string tname = mat[i].GetTexture(1).Name.ToString();
                        tname = tname.Replace(".xbm", texExtension);
                        writer.Write(Path.GetFileName(tname));
                        writer.Write("\n");
                    }
                    writer.Write("\n");
                }
                writer.Flush();
                writer.Close();
            }
        }

        public static float Clamp(float value, float min, float max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        private void MatrixToEuler(CMatrix3x3 rm, out float rx, out float ry, out float rz)
        {
            float r11 = rm.ax.val;
            float r12 = rm.ay.val;
            float r13 = rm.az.val;

            float r21 = rm.bx.val;
            float r22 = rm.by.val;
            float r23 = rm.bz.val;

            float r31 = rm.cx.val;
            float r32 = rm.cy.val;
            float r33 = rm.cz.val;

            float y = -(float)Math.Asin(Clamp(r13,-1.0f, 1.0f));
            float c = (float)Math.Cos(y);
            ry = y;
            if (Math.Abs(ry) >= Math.PI * 2.0)
            {
                ry = 0;
            }

            y *= (float)(180.0 / Math.PI);

            if(Math.Abs(c) > 0.0005f)
            {
                float invC = 1.0f / c;
                float rotx = r33 * invC;
                float roty = r23 * invC;
                rx = (float)Math.Atan2(roty, rotx);
                if (rx < 0)
                {
                    rx += (float)(Math.PI * 2.0);
                }

                rotx = r11 * invC;
                roty = r12 * invC;
                rz = (float)Math.Atan2(roty, rotx);
                if (rz < 0)
                {
                    rz += (float)(Math.PI * 2.0);
                }
            }
            else
            {
                rx = 0;
                rz = (float)Math.Atan2(-r21, r22);
                if (rz < 0)
                {
                    rz += (float)(Math.PI * 2.0);
                }
            }
        }

        private async Task ExportMeshAsync(string path, CR2WFile file)
        {
            var depot = MainController.Get().Configuration.DepotPath;
            string r4dataRoot = depot + "\\";

            List<MeshPart> meshParts = new List<MeshPart>();

            float RADIANS_TO_DEGREES = (float)(180 / Math.PI);

            IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
            irrparam.DriverType = DriverType.Null;
            irrparam.BitsPerPixel = 8;
            irrparam.WindowSize.Height = 8;
            irrparam.WindowSize.Width = 8;
            irrparam.Fullscreen = false;
            IrrlichtDevice device = IrrlichtDevice.CreateDevice(irrparam);

            foreach (var chunk in file.chunks)
            {
                if(chunk.REDType == "CSectorData")
                {
                    var fileNameOnly = Path.GetFileNameWithoutExtension(path);
                    var exportMeshDirectory = (ExportPath + "\\" + fileNameOnly);
                    if (!Directory.Exists(exportMeshDirectory))
                    {
                        // make it writable!
                        var di = Directory.CreateDirectory(exportMeshDirectory);
                        di.Attributes = di.Attributes & ~System.IO.FileAttributes.ReadOnly;
                    }

                    CSectorData sd = (CSectorData)chunk.data;
                    int blockInstanceIndex = 0;
                    foreach(var block in sd.BlockData)
                    {
                        if(block.packedObjectType == Enums.BlockDataObjectType.Mesh)
                        {
                            SVector3D position = block.position;
                            CMatrix3x3 rotation = block.rotationMatrix;
                            float rx, ry, rz;
                            MatrixToEuler(rotation, out rx, out ry, out rz); // radians

                            Vector3Df rot = new Vector3Df(rx * RADIANS_TO_DEGREES, ry * RADIANS_TO_DEGREES, rz * RADIANS_TO_DEGREES);
                            Vector3Df translation = new Vector3Df(position.X.val, position.Y.val, position.Z.val);
                            IrrlichtLime.Core.Matrix localToWorld = new IrrlichtLime.Core.Matrix(translation, rot);

                            // now get mesh to apply this to!
                            SBlockDataMeshObject mo = (SBlockDataMeshObject)block.packedObject;
                            ushort meshIndex = mo.meshIndex.val;
                            if (meshIndex > sd.Resources.Count)
                            {
                                continue;
                            }
                            string meshName = sd.Resources[meshIndex].pathHash.val;

                            if(string.IsNullOrEmpty(meshName))
                            {
                                continue;
                            }
                            string meshPath = r4dataRoot + meshName;

                            CR2WFile meshAssetFile;
                            using (var fs = new FileStream(meshPath, FileMode.Open, FileAccess.Read))
                            using (var reader = new BinaryReader(fs))
                            {
                                meshAssetFile = new CR2WFile();
                                meshAssetFile.FileName = meshPath; // needed for WKMesh loader!
                                meshAssetFile.Read(reader);
                                fs.Close();
                            }

                            CommonData cdata = new CommonData();
                            WKMesh renderMesh = new WKMesh(cdata);
                            renderMesh.LoadData(meshAssetFile, device);                            

                            var meshNameOnly = Path.GetFileNameWithoutExtension(meshPath);
                            meshNameOnly += "_" + blockInstanceIndex.ToString();

                            if (GeometryType == "OBJ")
                            {
                                if (!MergeMeshes)
                                {
                                    string filename = exportMeshDirectory + "\\" + meshNameOnly + ".obj";
                                    WriteMeshAsObj(filename, meshPath, renderMesh, localToWorld);
                                }
                                else
                                {
                                    if (renderMesh.CData.staticMesh.MeshBufferCount > 0)
                                    {
                                        MeshPart mp = new MeshPart();
                                        mp.Mesh = renderMesh;
                                        mp.Transform = localToWorld;
                                        meshParts.Add(mp);
                                    }
                                }
                            }
                            else if(GeometryType == "FBX")
                            {
                                //TODO - not working
                                /*
                                string filename = exportMeshDirectory + "\\" + meshNameOnly + ".fbx";
                                var cmd = new Wcc_lite.export()
                                {
                                    Depot = depot,
                                    File = meshName,
                                    Out = filename
                                };
                                await Task.Run(()=> MainController.Get().WccHelper.RunCommand(cmd));
                                */
                            }

                            foreach (var material in renderMesh.CData.materialInstances)
                            {
                                if (material.InstanceParameters != null)
                                {
                                    if (material.InstanceParameters.Count == 0)
                                    {
                                        if (material.BaseMaterial != null)
                                        {
                                            CR2WFile cr2w;
                                            using (var fs = new FileStream(r4dataRoot + material.BaseMaterial.DepotPath, FileMode.Open, FileAccess.Read))
                                            using (var reader = new BinaryReader(fs))
                                            {
                                                cr2w = new CR2WFile();
                                                cr2w.Read(reader);
                                                fs.Close();
                                            }

                                            // it could be a CMaterialGraph, if so use a default
                                            // set the materialInstances to the texture references
                                            if (cr2w.chunks[0].data.REDType == "CMaterialInstance")
                                            {
                                                CMaterialInstance mi = cr2w.chunks[0].data as CMaterialInstance;
                                                foreach (var tex in mi.InstanceParameters)
                                                {
                                                    if (tex.Variant.REDType == "handle:ITexture")
                                                    {
                                                        string inputpath = ((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.ITexture>)tex.Variant).DepotPath;
                                                        string texName = r4dataRoot + inputpath;
                                                        string pngtexName = inputpath.Replace(".xbm", "." + TextureType);
                                                        string outputTexturePath = exportMeshDirectory + "\\" + Path.GetFileName(pngtexName);

                                                        if (!File.Exists(outputTexturePath))
                                                        {
                                                            System.Drawing.Imaging.ImageFormat fmt = System.Drawing.Imaging.ImageFormat.Png;
                                                            switch(TextureType)
                                                            {
                                                                case "BMP":
                                                                    fmt = System.Drawing.Imaging.ImageFormat.Bmp;
                                                                    break;
                                                                case "PNG":
                                                                    fmt = System.Drawing.Imaging.ImageFormat.Png;
                                                                    break;
                                                                case "JPG":
                                                                    fmt = System.Drawing.Imaging.ImageFormat.Jpeg;
                                                                    break;
                                                                case "TGA":
                                                                    fmt = System.Drawing.Imaging.ImageFormat.Tiff; // crap.. really? no tga
                                                                    break;
                                                                default:
                                                                    break;
                                                            }

                                                            // make it from the xbm
                                                            CR2WFile imgAssetFile;
                                                            using (var fs = new FileStream(texName, FileMode.Open, FileAccess.Read))
                                                            using (var reader = new BinaryReader(fs))
                                                            {
                                                                imgAssetFile = new CR2WFile();
                                                                imgAssetFile.Read(reader);
                                                                fs.Close();

                                                                CBitmapTexture xbm = ((CBitmapTexture)imgAssetFile.chunks[0].data);
                                                                {
                                                                    System.Drawing.Bitmap xbmImage = new System.Drawing.Bitmap(ImageUtility.Xbm2Bmp(xbm));
                                                                    xbmImage.Save(outputTexturePath, fmt);
                                                                    xbmImage.Dispose();
                                                                    xbmImage = null;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                //TODO?
                                                // CMaterialGraph...
                                            }
                                        }
                                    }
                                    else
                                    {
                                        foreach (var tex in material.InstanceParameters)
                                        {
                                            if (tex.Variant.REDType == "handle:ITexture")
                                            {
                                                if (((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.ITexture>)tex.Variant).DepotPath != null)
                                                {
                                                    string inputpath = ((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.ITexture>)tex.Variant).DepotPath;
                                                    string texName = r4dataRoot + inputpath;
                                                    string pngtexName = inputpath.Replace(".xbm", "." + TextureType);
                                                    string outputTexturePath = exportMeshDirectory + "\\" + Path.GetFileName(pngtexName);
                                                    
                                                    if (!File.Exists(outputTexturePath))
                                                    {
                                                        System.Drawing.Imaging.ImageFormat fmt = System.Drawing.Imaging.ImageFormat.Png;
                                                        switch (TextureType)
                                                        {
                                                            case "BMP":
                                                                fmt = System.Drawing.Imaging.ImageFormat.Bmp;
                                                                break;
                                                            case "PNG":
                                                                fmt = System.Drawing.Imaging.ImageFormat.Png;
                                                                break;
                                                            case "JPG":
                                                                fmt = System.Drawing.Imaging.ImageFormat.Jpeg;
                                                                break;
                                                            case "TGA":
                                                                fmt = System.Drawing.Imaging.ImageFormat.Tiff;
                                                                break;
                                                            default:
                                                                break;
                                                        }
                                                        // make it from the xbm
                                                        CR2WFile imgAssetFile;
                                                        using (var fs = new FileStream(texName, FileMode.Open, FileAccess.Read))
                                                        using (var reader = new BinaryReader(fs))
                                                        {
                                                            imgAssetFile = new CR2WFile();
                                                            imgAssetFile.Read(reader);
                                                            fs.Close();

                                                            CBitmapTexture xbm = ((CBitmapTexture)imgAssetFile.chunks[0].data);
                                                            {
                                                                System.Drawing.Bitmap xbmImage = new System.Drawing.Bitmap(ImageUtility.Xbm2Bmp(xbm));
                                                                xbmImage.Save(outputTexturePath, fmt);
                                                                xbmImage.Dispose();
                                                                xbmImage = null;
                                                            }
                                                        }
                                                    }                                                    
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            ++blockInstanceIndex;
                        }
                    }

                    Logger.LogString($"exported.\r\n", Logtype.Success);
                }
            }

            if (MergeMeshes && meshParts.Count > 0)
            {
                if (GeometryType == "OBJ")
                {
                    var fileNameOnly = Path.GetFileNameWithoutExtension(path);
                    var exportMeshDirectory = (ExportPath + "\\" + fileNameOnly);
                    string filename = exportMeshDirectory + "\\" + fileNameOnly + ".obj";
                    WriteMeshesAsObj(filename, meshParts);
                }
                else
                {
                    // TODO
                }
            }

            device.Close();
            device.Drop();
            device.Dispose();
        }

        #endregion        
    }
}
