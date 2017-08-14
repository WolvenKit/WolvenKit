using System;
using System.Windows.Forms;
using System.Threading;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;
using IrrlichtLime.GUI;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Cache;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using System.Collections.Generic;

namespace WolvenKit.Render
{
    public partial class frmRender : DockContent
    {
        /// <summary>
        /// Thread variable for irrlicht thread.
        /// </summary>
        private Thread irrThread;

        /// <summary>
        /// Form constructor.
        /// </summary>
        public frmRender()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
        }

        private CR2WFile _file;

        /// <summary>
        /// Witcher file containing mesh data.
        /// </summary>
        public CR2WFile File
        {
            get { return _file; }
            set
            {
                try
                {
                    _file = value;
                    
                    switch (Path.GetExtension(_file.FileName))
                    {
                        case ".w2mesh":
                            ReadMeshBufferInfos();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
            }
        }

        /// <summary>
        /// Reads mesh buffer infos.
        /// </summary>
        void ReadMeshBufferInfos()
        {
            SBufferInfos bufferInfos = new SBufferInfos();

            // *************** READ CHUNK INFOS ***************
            foreach (var chunk in _file.chunks)
            {
                if (chunk.Type == "CMesh")
                {
                    List<SVertexBufferInfos> vertexBufferInfos = new List<SVertexBufferInfos>();
                    var cookedDatas = chunk.GetVariableByName("cookedData") as CVector;
                    foreach (var cookedData in cookedDatas.variables)
                    {
                        if (cookedData.Name == "renderChunks")
                        {
                            var bytes = ((CByteArray)cookedData).Bytes;
                            var nbBuffers = bytes[0];
                            int curr = 1;
                            for (uint i = 0; i < nbBuffers; i++)
                            {
                                SVertexBufferInfos buffInfo = new SVertexBufferInfos();

                                curr += 1; // Unknown
                                buffInfo.verticesCoordsOffset = bytes.SubArray(ref curr, 4).GetUint();
                                buffInfo.uvOffset = bytes.SubArray(ref curr, 4).GetUint();
                                buffInfo.normalsOffset = bytes.SubArray(ref curr, 4).GetUint();

                                curr += 9; // Unknown
                                buffInfo.indicesOffset = bytes.SubArray(ref curr, 4).GetUint();
                                curr += 1; // 0x1D

                                buffInfo.nbVertices = bytes.SubArray(ref curr, 2).GetUshort();
                                buffInfo.nbIndices = bytes.SubArray(ref curr, 4).GetUint();
                                curr += 3; // Unknown
                                buffInfo.lod = bytes.SubArray(ref curr, 1).GetByte(); // lod ?

                                vertexBufferInfos.Add(buffInfo);
                            }
                        }
                        else if (cookedData.Name == "indexBufferOffset")
                        {
                            bufferInfos.indexBufferOffset = uint.Parse(cookedData.ToString());
                        }
                        else if (cookedData.Name == "indexBufferSize")
                        {
                            bufferInfos.indexBufferSize = uint.Parse(cookedData.ToString());
                        }
                        else if (cookedData.Name == "vertexBufferOffset")
                        {
                            bufferInfos.vertexBufferOffset = uint.Parse(cookedData.ToString());
                        }
                        else if (cookedData.Name == "vertexBufferSize")
                        {
                            bufferInfos.vertexBufferSize = uint.Parse(cookedData.ToString());
                        }
                        else if (cookedData.Name == "quantizationOffset")
                        {
                            bufferInfos.quantizationOffset.X = float.Parse((cookedData as CVector).variables[0].ToString());
                            bufferInfos.quantizationOffset.Y = float.Parse((cookedData as CVector).variables[1].ToString());
                            bufferInfos.quantizationOffset.Z = float.Parse((cookedData as CVector).variables[2].ToString());
                        }
                        else if (cookedData.Name == "quantizationScale")
                        {
                            bufferInfos.quantizationScale.X = float.Parse((cookedData as CVector).variables[0].ToString());
                            bufferInfos.quantizationScale.Y = float.Parse((cookedData as CVector).variables[1].ToString());
                            bufferInfos.quantizationScale.Z = float.Parse((cookedData as CVector).variables[2].ToString());
                        }
                    }
                    bufferInfos.verticesBuffer = vertexBufferInfos;
                    var meshChunks = chunk.GetVariableByName("chunks") as CArray;
                    foreach (var meshChunk in meshChunks.array)
                    {
                        SMeshInfos meshInfo = new SMeshInfos();
                        foreach (var mesh in (meshChunk as CVector).variables)
                        {
                            if (mesh.Name == "numVertices")
                            {
                                meshInfo.numVertices = uint.Parse(mesh.ToString());
                            }
                            else if (mesh.Name == "numIndices")
                            {
                                meshInfo.numIndices = uint.Parse(mesh.ToString());
                            }
                            else if (mesh.Name == "numBonesPerVertex")
                            {
                                meshInfo.numBonesPerVertex = uint.Parse(mesh.ToString());
                            }
                            else if (mesh.Name == "firstVertex")
                            {
                                meshInfo.firstVertex = uint.Parse(mesh.ToString());
                            }
                            else if (mesh.Name == "firstIndex")
                            {
                                meshInfo.firstIndex = uint.Parse(mesh.ToString());
                            }
                            else if (mesh.Name == "vertexType")
                            {
                                if ((mesh as CName).Value == "MVT_StaticMesh")
                                    meshInfo.vertexType = SMeshInfos.EMeshVertexType.EMVT_STATIC;
                                else if ((mesh as CName).Value == "MVT_SkinnedMesh")
                                    meshInfo.vertexType = SMeshInfos.EMeshVertexType.EMVT_SKINNED;
                            }
                            else if (mesh.Name == "materialID")
                            {
                                meshInfo.materialID = uint.Parse(mesh.ToString());
                            }
                        }
                        meshInfos.Add(meshInfo);
                    }
                }
                else if (chunk.Type == "CMaterialInstance")
                {
                    materialInstances.Add(chunk.data as CMaterialInstance);
                }
            }

            // *************** READ MESH BUFFER INFOS ***************
            foreach (var meshInfo in meshInfos)
            {
                // IMPLEMENTED FROM jlouis' witcherconverter
                // http://jlouisb.users.sourceforge.net/
                // https://bitbucket.org/jlouis/witcherconverter

                SVertexBufferInfos vBufferInf = new SVertexBufferInfos();
                uint nbVertices = 0;
                uint firstVertexOffset = 0;
                uint nbIndices = 0;
                uint firstIndiceOffset = 0;
                for (int i = 0; i < bufferInfos.verticesBuffer.Count; i++)
                {
                    nbVertices += bufferInfos.verticesBuffer[i].nbVertices;
                    if (nbVertices > meshInfo.firstVertex)
                    {
                        vBufferInf = bufferInfos.verticesBuffer[i];
                        // the index of the first vertex in the buffer
                        firstVertexOffset = meshInfo.firstVertex - (nbVertices - vBufferInf.nbVertices);
                        break;
                    }
                }
                for (int i = 0; i < bufferInfos.verticesBuffer.Count; i++)
                {
                    nbIndices += bufferInfos.verticesBuffer[i].nbIndices;
                    if (nbIndices > meshInfo.firstIndex)
                    {
                        vBufferInf = bufferInfos.verticesBuffer[i];
                        firstIndiceOffset = meshInfo.firstIndex - (nbIndices - vBufferInf.nbIndices);
                        break;
                    }
                }

                using (StreamReader sr = new StreamReader(_file.FileName + ".1.buffer"))
                {
                    uint vertexSize = 8;
                    if (meshInfo.vertexType == SMeshInfos.EMeshVertexType.EMVT_SKINNED)
                        vertexSize += meshInfo.numBonesPerVertex * 2;

                    sr.BaseStream.Seek(vBufferInf.verticesCoordsOffset + firstVertexOffset * vertexSize, SeekOrigin.Begin);

                    List<Vertex3D> vertex3DCoords = new List<Vertex3D>();
                    Color defaultColor = new Color(255, 255, 255, 255);
                    for (int i = 0; i < meshInfo.numVertices; i++)
                    {
                        ushort x, y, z, w;

                        byte[] buff = new byte[2];
                        sr.BaseStream.Read(buff, 0, 2);
                        x = buff.GetUshort();
                        sr.BaseStream.Read(buff, 0, 2);
                        y = buff.GetUshort();
                        sr.BaseStream.Read(buff, 0, 2);
                        z = buff.GetUshort();
                        sr.BaseStream.Read(buff, 0, 2);
                        w = buff.GetUshort();

                        // skip skinning data
                        if (meshInfo.vertexType == SMeshInfos.EMeshVertexType.EMVT_SKINNED)
                        {
                            sr.BaseStream.Seek(meshInfo.numBonesPerVertex * 2, SeekOrigin.Current);
                        }

                        Vertex3D vertex3DCoord = new Vertex3D();
                        vertex3DCoord.Position = new Vector3Df(x, y, z) / 65535f * bufferInfos.quantizationScale + bufferInfos.quantizationOffset;
                        vertex3DCoord.Color = defaultColor;
                        vertex3DCoords.Add(vertex3DCoord);
                    }

                    sr.BaseStream.Seek(vBufferInf.uvOffset + firstVertexOffset * 4, SeekOrigin.Begin);

                    for (int i = 0; i < meshInfo.numVertices; i++)
                    {
                        ushort u, v;

                        byte[] buff = new byte[2];
                        sr.BaseStream.Read(buff, 0, 2);
                        u = buff.GetUshort();
                        sr.BaseStream.Read(buff, 0, 2);
                        v = buff.GetUshort();

                        float uf = u.ToFloat();
                        float vf = v.ToFloat();

                        Vertex3D vertex3DCoord = vertex3DCoords[i];
                        vertex3DCoord.TCoords = new Vector2Df(uf, vf);
                        vertex3DCoords[i] = vertex3DCoord;
                    }

                    // Indices -------------------------------------------------------------------
                    sr.BaseStream.Seek(bufferInfos.indexBufferOffset + vBufferInf.indicesOffset + firstIndiceOffset * 2, SeekOrigin.Begin);

                    List<ushort> indices = new List<ushort>();
                    for (int i = 0; i < meshInfo.numIndices; i++)
                        indices.Add(0);

                    for (int i = 0; i < meshInfo.numIndices; i++)
                    {
                        ushort index;

                        byte[] buff = new byte[2];
                        sr.BaseStream.Read(buff, 0, 2);
                        index = buff.GetUshort();

                        // Indice need to be inversed for the normals
                        if (i % 3 == 0)
                            indices[i] = index;
                        else if (i % 3 == 1)
                            indices[i + 1] = index;
                        else if (i % 3 == 2)
                            indices[i - 1] = index;
                    }

                    MeshBuffer meshBuff = MeshBuffer.Create(VertexType.Standard, IndexType._16Bit);
                    staticMesh.AddMeshBuffer(meshBuff);
                    meshBuff.Append(vertex3DCoords, indices);
                    meshBuff.RecalculateBoundingBox();
                    meshBuff.Drop();            
                }
            }
        }

        /// <summary>
        /// Starts an irrlicht thread.
        /// </summary>
        private void StartIrrThread()
        {
            ThreadStart irrThreadStart = new ThreadStart(StartIrr);
            irrThread = new Thread(irrThreadStart);
            irrThread.IsBackground = true;
            irrThread.Start();
        }

        /// <summary>
        /// Restarts an irrlicht thread.
        /// </summary>
        private void RestartIrrThread()
        {
            irrThread.Abort();
            // restart an irrlicht thread
            StartIrrThread();
        }

        /// <summary>
        /// The irrlicht thread for rendering.
        /// </summary>
        private void StartIrr()
        {
            try
            {
                IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
                if (irrlichtPanel.InvokeRequired)
                    irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
                irrparam.DriverType = DriverType.Direct3D9;
                irrparam.BitsPerPixel = 16;

                device = IrrlichtDevice.CreateDevice(irrparam);

                if (device == null) throw new NullReferenceException("Could not create device for engine!");

                driver = device.VideoDriver;
                smgr  = device.SceneManager;
                gui = device.GUIEnvironment;

                //AnimatedMesh mesh = smgr.GetMesh(modelPath);
                //AnimatedMeshSceneNode node = smgr.AddAnimatedMeshSceneNode(mesh);

                smgr.MeshManipulator.RecalculateNormals(staticMesh);
                MeshSceneNode node = smgr.AddMeshSceneNode(staticMesh);
 
                if (node == null) throw new Exception("Could not load file!");

                node.Scale = new Vector3Df(3.0f);
                node.SetMaterialFlag(MaterialFlag.Lighting, false);
                SetMaterials(driver, node);

                CameraSceneNode camera = smgr.AddCameraSceneNode(null, new Vector3Df(node.BoundingBox.Radius, 0, 0), new Vector3Df(0, 0, 0));
                camera.NearValue = 0.001f;
                scaleMul = node.BoundingBox.Radius/4;

                MethodInvoker UpdateRichTextBoxInvoker = new MethodInvoker(delegate { UpdateRichTextBox(driver.FPS); });

                while (device.Run())
                {
                    driver.BeginScene(ClearBufferFlag.All, new Color(100, 101, 140));

                    node.Position = modelPosition;
                    node.Rotation = modelAngle;
                    this.Invoke(UpdateRichTextBoxInvoker);

                    smgr.DrawAll();
                    gui.DrawAll();

                    driver.EndScene();
                }

                device.Drop();
            }
            catch (NullReferenceException) { }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                if (!this.IsDisposed)
                {
                    MessageBox.Show(ex.Message);
                    //this.Invoke(new MethodInvoker(delegate { this.Close(); }));
                }
            }
        }

        /// <summary>
        /// Sets the material textures for the mesh.
        /// </summary>
        private void SetMaterials(VideoDriver driver, MeshSceneNode node)
        {
            List<Material> materials = new List<Material>();
            //mat.Type = MaterialType.Solid;
            foreach (var materialInstance in materialInstances)
            {
                Material mat = new Material();
                foreach (var material in materialInstance.instanceParameters)
                {
                    switch (material.Name)
                    {
                        case "Diffuse":
                            Texture diffTexture = GetTexture(driver, (material as CHandle).Handle);
                            mat.SetTexture(0, diffTexture);
                            break;
                        case "Normal":
                            Texture normTexture = GetTexture(driver, (material as CHandle).Handle);
                            mat.SetTexture(1, normTexture);
                            //mat.Type = MaterialType.NormalMapSolid;
                            break;
                    }
                }
                materials.Add(mat);
            }
            for (int i = 0; i < meshInfos.Count; i++)
            {
                if (meshInfos[i].materialID < materials.Count)
                {
                    Material mat = materials[(int)meshInfos[i].materialID];
                    node.SetMaterialTexture(i, mat.GetTexture(i));
                }
            }
        }

        private bool suppressTextureWarning = false;

        /// <summary>
        /// Try to get the texture file.
        /// </summary>
        private Texture GetTexture(VideoDriver driver, string handleFilename)
        {
            string texturePath = Path.GetDirectoryName(_file.FileName) + @"\" + Path.GetFileNameWithoutExtension(handleFilename);
            string[] textureFileExtensions = { ".dds", ".bmp", ".tga", ".jpg", ".jpeg", ".png", ".xbm" };
            Texture texture = null;
            foreach (var textureFileExtension in textureFileExtensions)
            {
                texture = driver.GetTexture(texturePath + textureFileExtension);
                if (texture != null) break;
            }
            //ImageUtility.Xbm2Dds();
            if (texture == null && !suppressTextureWarning)
            {
                suppressTextureWarning = true;
                MessageBox.Show("Have you extracted texture files properly?" + "\n\n" + "Could not parse texture: " + texturePath, "Missing texture!");
            }
            return texture;
        }

        #region Common Data

        //private string modelPath = "";
        private StaticMesh staticMesh = StaticMesh.Create();
        private List<CMaterialInstance> materialInstances = new List<CMaterialInstance>();
        List<SMeshInfos> meshInfos = new List<SMeshInfos>();

        //private static Quaternion modelAngle = new Quaternion(new Vertex3f(), 0);
        private Vector3Df modelPosition = new Vector3Df(0.0f);
        private Vector3Df modelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);
        private float scaleMul = 1;

        private IrrlichtDevice device;
        private VideoDriver driver;
        private SceneManager smgr;
        private GUIEnvironment gui;

        private bool modelAutorotating = true;
        //private static float angle_autorotate = 0;
        //private static float angle_autorotate_rad;
        private const float PI_OVER_180 = (float)Math.PI / 180.0f;

        #endregion

        /// <summary>
        /// Timer ticks for auto rotation.
        /// </summary>
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Change camera rotation
            if (modelAutorotating)
                modelAngle.Y = (modelAngle.Y + 1f) % 360.0f;
            //angle_autorotate_rad = angle_autorotate * PI_OVER_180;

            // Issue a new frame after this render
            // irrlichtPanel.Invalidate();
        }

        /// <summary>
        /// Updates textboxes.
        /// </summary>
        private void UpdateRichTextBox(int FPS)
        {
            this.textBoxPos.Text = String.Format("X: {0} Y: {1} Z: {2}", modelPosition.X, modelPosition.Y, modelPosition.Z);
            this.textBoxPos.Width = TextRenderer.MeasureText(this.textBoxPos.Text, this.textBoxPos.Font).Width;
            this.textBoxRotation.Text = String.Format("Yaw: {0} Roll: {1}", modelAngle.Y, modelAngle.Z);
            this.textBoxRotation.Width = TextRenderer.MeasureText(this.textBoxRotation.Text, this.textBoxRotation.Font).Width;
            this.textBoxFPS.Text = String.Format("FPS: {0}", FPS);
            this.textBoxFPS.Width = TextRenderer.MeasureText(this.textBoxFPS.Text, this.textBoxFPS.Font).Width;
        }

        #region event handlers
        private void Bithack3D_Load(object sender, EventArgs e)
        {
            // OpenFileDialog for importing 3D models
            /*OpenFileDialog open3dModel = new OpenFileDialog();
            open3dModel.InitialDirectory = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Models"));
            // If dir not found then use exe dir
            if (Directory.Exists(open3dModel.InitialDirectory) == false)
            {
                open3dModel.InitialDirectory = Environment.CurrentDirectory;
            }

            if (open3dModel.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    modelPath = Path.GetFullPath(open3dModel.FileName).Replace(@"\", "/");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: Could not read file from disk. Original error: " + ex.Message);
                    this.BeginInvoke(new MethodInvoker(Close));
                }
            }
            else
            {
                MessageBox.Show(this, "No file selected!");
                this.BeginInvoke(new MethodInvoker(Close));
            }*/

            resizeTimer.Tick += ResizeTimer;
            resizeTimer.Interval = 1000;

            // start an irrlicht thread
            StartIrrThread();
        }

        private void Bithack3D_FormClosing(object sender, FormClosingEventArgs e)
        {
            irrThread.Abort();
        }

        private static bool renderStarted = true;
        private static float currCursorPosX = 0;
        private static float currCursorPosY = 0;

        private void irrlichtPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (renderStarted && e.Button == MouseButtons.Left)
            {
                modelAutorotating = false;
                // Around Y axis
                float deltaDirection = currCursorPosX - e.X;
                modelAngle.Y = (modelAngle.Y + deltaDirection / 4.0f) % 360.0f;
                if (modelAngle.Y < 0)
                    modelAngle.Y = 360.0f + modelAngle.Y;

                // Around Z axis
                deltaDirection = currCursorPosY - e.Y;
                modelAngle.Z = (modelAngle.Z + deltaDirection / 20.0f) % 360.0f;
                if (modelAngle.Z < 0)
                    modelAngle.Z = 360.0f + modelAngle.Z;
            }
            else if (renderStarted && e.Button == MouseButtons.Right)
            {
                modelAutorotating = false;
                float deltaDirection = currCursorPosX - e.X;
                modelPosition.Z = modelPosition.Z - deltaDirection * scaleMul / 100;

                deltaDirection = currCursorPosY - e.Y;
                modelPosition.Y = modelPosition.Y + deltaDirection * scaleMul / 100;
            }
            currCursorPosX = e.X;
            currCursorPosY = e.Y;

            // This method should only work when the mouse is captured by the Form.
            // For instance, when the left mouse button is pressed:
            // It traps the mouse to be able to scroll infinitely
            /*if (!(e.Button == MouseButtons.Left || e.Button == MouseButtons.Right))
                return;

            Point p = PointToScreen(e.Location);
            int x = p.X;
            int y = p.Y;
            Rectangle bounds = this.Bounds;

            if (x <= bounds.Left + 1)
                x = bounds.Right - 10;
            else if (x >= bounds.Right - 9)
                x = bounds.Left + 2;

            if (y <= bounds.Top + 8)
                y = bounds.Bottom - 2;
            else if (y >= bounds.Bottom - 1)
                y = bounds.Top + 9;

            if (x != p.X || y != p.Y)
            {
                Cursor.Position = new Point(x, y);
                currentPosX = x - (bounds.Left + 1);
                currentPosY = y - (bounds.Top + 1);
            }*/
        }

        private void Bithack3D_MouseWheel(object sender, MouseEventArgs e)
        {
            if (renderStarted)
                modelPosition.X = modelPosition.X + (float)e.Delta / 1000.0f;
        }

        private void Bithack3D_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Restart autorotation
                modelAutorotating = true;
                modelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);
                modelPosition = new Vector3Df(0.0f);
            }
        }

        private void Bithack3D_ResizeEnd(object sender, EventArgs e) { }

        private void Bithack3D_Resize(object sender, EventArgs e) { }

        private System.Windows.Forms.Timer resizeTimer = new System.Windows.Forms.Timer();

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            resizeTimer.Start();
        }

        private void ResizeTimer(object sender, EventArgs e)
        {
            resizeTimer.Stop();
            if (irrThread != null)
            {
                RestartIrrThread();
            }
        }
        #endregion

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sf = new SaveFileDialog())
            {
                sf.Filter = "Irrlicht mesh | *.irrm | Collada mesh | *.coll | STL Mesh | *.stl | OBJ Mesh | *.obj | PLY Mesh | *.ply | B3D Mesh | *.b3d";
                if(sf.ShowDialog() == DialogResult.OK)
                {
                    MeshWriterType mwt = MeshWriterType.Obj;
                    switch(Path.GetExtension(sf.FileName))
                    {
                        case "irrm":
                            mwt = MeshWriterType.IrrMesh;
                            break;
                        case "coll":
                            mwt = MeshWriterType.Collada;
                            break;
                        case "obj":
                            mwt = MeshWriterType.Obj;
                            break;
                        case "stl":
                            mwt = MeshWriterType.Stl;
                            break;
                        case "ply":
                            mwt = MeshWriterType.Ply;
                            break;
                        case "b3d":
                            mwt = MeshWriterType.B3d;
                            break;
                    }
                    var mw = smgr.CreateMeshWriter(mwt);
                    if(mw.WriteMesh(device.FileSystem.CreateWriteFile(sf.FileName), staticMesh, MeshWriterFlag.None))
                        MessageBox.Show(this,"Sucessfully wrote file!","WolvenKit",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Failed tos file!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
