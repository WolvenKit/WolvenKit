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
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using System.Collections.Generic;

namespace WolvenKit.Render
{
    public partial class frmRender : DockContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Thread irrThread;
        public frmRender()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private CR2WFile _file;

        public CR2WFile File
        {
            get { return _file; }
            set
            {
                try
                {
                    _file = value;
                    SBufferInfos bufferInfos = new SBufferInfos();
                    List<SMeshInfos> meshInfos = new List<SMeshInfos>();
                    switch (Path.GetExtension(_file.FileName))
                    {
                        case ".w2mesh":
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
                                    foreach (var mesh in (meshChunk as CVector).variables)
                                    {
                                        SMeshInfos meshInfo = new SMeshInfos();
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
                                        meshInfos.Add(meshInfo);
                                    }
                                }
                            }
                            break;
                    }

                    foreach (var meshInfo in meshInfos)
                    {
                        SVertexBufferInfos vBufferInf;
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
                            /*IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
                            if (irrlichtPanel.InvokeRequired)
                                irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
                            irrparam.DriverType = DriverType.Direct3D9;
                            irrparam.BitsPerPixel = 16;

                            IrrlichtDevice device = IrrlichtDevice.CreateDevice(irrparam);

                            if (device == null) throw new Exception("Could not create device for engine!");

                            device.SetWindowCaption("Hello World! - Irrlicht Engine Demo");

                            VideoDriver driver = device.VideoDriver;
                            SceneManager smgr = device.SceneManager;
                            GUIEnvironment gui = device.GUIEnvironment;

                            SkinnedMesh buffer = smgr.CreateSkinnedMesh();*/
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
            }
        }

        private void StartIrrThread()
        {
            ThreadStart irrThreadStart = new ThreadStart(StartIrr);
            irrThread = new Thread(irrThreadStart);
            irrThread.IsBackground = true;
            irrThread.Start();
        }

        private void RestartIrrThread()
        {
            irrThread.Abort();
            // restart an irrlicht thread
            StartIrrThread();
            resizing = false;
        }

        private void StartIrr()
        {
            try
            {
                IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
                if (irrlichtPanel.InvokeRequired)
                    irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
                irrparam.DriverType = DriverType.Direct3D9;
                irrparam.BitsPerPixel = 16;

                IrrlichtDevice device = IrrlichtDevice.CreateDevice(irrparam);

                if (device == null) throw new Exception("Could not create device for engine!");

                device.SetWindowCaption("Hello World! - Irrlicht Engine Demo");

                VideoDriver driver = device.VideoDriver;
                SceneManager smgr = device.SceneManager;
                GUIEnvironment gui = device.GUIEnvironment;

                gui.AddStaticText("Hello World! This is the Irrlicht Software renderer!",
                    new Recti(10, 10, 260, 22), true);

                AnimatedMesh mesh = smgr.GetMesh(modelPath);
                AnimatedMeshSceneNode node = smgr.AddAnimatedMeshSceneNode(mesh);

                if (node == null) throw new Exception("Could not load file!");

                node.SetMaterialFlag(MaterialFlag.Lighting, false);
                if(mesh.MeshType == AnimatedMeshType.MD2)
                    node.SetMD2Animation(AnimationTypeMD2.Stand);
                //node.SetMaterialTexture(0, driver.GetTexture("../../Media/sydney.bmp"));

                smgr.AddCameraSceneNode(null, new Vector3Df(node.BoundingBox.Radius*2f, node.BoundingBox.Radius, 0), new Vector3Df(0, node.BoundingBox.Radius, 0));
                scaleMul = node.BoundingBox.Radius/2;

                MethodInvoker UpdateRichTextBoxInvoker = new MethodInvoker(delegate { UpdateRichTextBox(); });

                while (device.Run())
                {
                    driver.BeginScene(ClearBufferFlag.All, new IrrlichtLime.Video.Color(100, 101, 140));

                    node.Position = modelPosition;
                    node.Rotation = modelAngle;
                    this.Invoke(UpdateRichTextBoxInvoker);

                    smgr.DrawAll();
                    gui.DrawAll();

                    driver.EndScene();
                }

                device.Drop();
            }
            catch (Exception ex)
            {
                if (!(ex is ThreadAbortException))
                {
                    MessageBox.Show(ex.Message);
                    this.Invoke(new MethodInvoker(delegate { this.Close(); }));
                }
            }
        }

        #region Common Data

        private string modelPath = "";

        //private static Quaternion modelAngle = new Quaternion(new Vertex3f(), 0);
        private static Vector3Df modelPosition = new Vector3Df(0.0f, 0.0f, 0.0f);
        private static Vector3Df modelAngle = new Vector3Df();
        private static float scaleMul = 1;

        private static bool model_autorotating = true;
        //private static float angle_autorotate = 0;
        //private static float angle_autorotate_rad;
        private const float PI_OVER_180 = (float)Math.PI / 180.0f;

        #endregion

        private static int previousTick = 0;
        private static int deltaTick = 0;

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Change camera rotation
            if (model_autorotating)
                modelAngle.Y = (modelAngle.Y + 1f) % 360.0f;
            //angle_autorotate_rad = angle_autorotate * PI_OVER_180;

            var currentTick = Environment.TickCount;
            deltaTick = currentTick - previousTick;
            previousTick = currentTick;

            // Issue a new frame after this render
            // irrlichtPanel.Invalidate();
        }

        private void UpdateRichTextBox()
        {
            this.textBoxPos.Text = String.Format("X: {0} Y: {1} Z: {2}", modelPosition.X, modelPosition.Y, modelPosition.Z);
            this.textBoxPos.Width = TextRenderer.MeasureText(this.textBoxPos.Text, this.textBoxPos.Font).Width;
            this.textBoxRotation.Text = String.Format("Yaw: {0} Pitch: {1}", modelAngle.Y, modelAngle.X);
            this.textBoxRotation.Width = TextRenderer.MeasureText(this.textBoxRotation.Text, this.textBoxRotation.Font).Width;
            this.textBoxFPS.Text = String.Format("FPS: {0}", deltaTick == 0 ? 0 : 1000 / deltaTick);
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
            this.BeginInvoke(new MethodInvoker(Close));

            // start an irrlicht thread
            StartIrrThread();
        }

        private void Bithack3D_FormClosing(object sender, FormClosingEventArgs e)
        {
            irrThread.Abort();
        }

        private static bool renderStarted = true;
        private static float currentPosX = 0;
        private static float currentPosY = 0;

        private void irrlichtPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (renderStarted && e.Button == MouseButtons.Left)
            {
                model_autorotating = false;
                // Around Y axis
                float deltaDirection = currentPosX - e.X;
                modelAngle.Y = (modelAngle.Y + deltaDirection / 4.0f) % 360.0f;
                if (modelAngle.Y < 0)
                    modelAngle.Y = 360.0f + modelAngle.Y;

                // Around X axis
                deltaDirection = currentPosY - e.Y;
                modelAngle.Z = (modelAngle.Z + deltaDirection / 40.0f) % 360.0f;
                if (modelAngle.Z < 0)
                    modelAngle.Z = 360.0f + modelAngle.Z;
            }
            else if (renderStarted && e.Button == MouseButtons.Right)
            {
                model_autorotating = false;
                float deltaDirection = currentPosX - e.X;
                modelPosition.Z = modelPosition.Z - deltaDirection * scaleMul / 100;

                deltaDirection = currentPosY - e.Y;
                modelPosition.Y = modelPosition.Y + deltaDirection * scaleMul / 100;
            }
            currentPosX = e.X;
            currentPosY = e.Y;

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
                model_autorotating = true;
                modelAngle.X = modelAngle.Y = modelAngle.Z = 0;
                modelPosition.X = 0;
                modelPosition.Y = 0;
                modelPosition.Z = 0;
            }
        }

        private bool resizing = false;
        FormWindowState prevState = FormWindowState.Normal;

        private void Bithack3D_ResizeEnd(object sender, EventArgs e)
        {
            if (resizing)
            {
                RestartIrrThread();
            }
        }

        private void Bithack3D_Resize(object sender, EventArgs e)
        {
            resizing = true;

            if (prevState != WindowState)
            {
                prevState = WindowState;
                RestartIrrThread();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (irrThread != null)
            {
                RestartIrrThread();
            }
        }
        #endregion

    }
}
