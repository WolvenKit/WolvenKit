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
        /// The delegate to load a document.
        /// </summary>
        public delegate CR2WFile LoadDocumentAndGetFile(string filename);
        /// <summary>
        /// The frmMain load document function.
        /// </summary>
        public LoadDocumentAndGetFile LoadDocument;

        /// <summary>
        /// Form constructor.
        /// </summary>
        public frmRender()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
        }

        private CR2WFile meshFile;
        private CR2WFile rigFile;
        private CR2WFile animFile;

        /// <summary>
        /// Witcher file containing mesh data.
        /// </summary>
        public CR2WFile MeshFile
        {
            get { return meshFile; }
            set
            {
                try
                {
                    meshFile = value;
                    mesh = new Mesh(cdata);
                    mesh.LoadData(meshFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "MeshFile error:" + ex.Message);
                }
            }
        }
        /// <summary>
        /// Witcher file containing rig data.
        /// </summary>
        public CR2WFile RigFile
        {
            get { return rigFile; }
            set
            {
                try
                {
                    rigFile = value;
                    rig = new Rig(cdata);
                    rig.LoadData(rigFile);
                    modelAngle = new Vector3Df(startModelAngle.X, startModelAngle.Y, startModelAngle.Z);
                    RestartIrrThread();
                    loadAnimToolStripMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "RigFile error:" + ex.Message);
                }
            }
        }
        /// <summary>
        /// Witcher file containing animation data.
        /// </summary>
        public CR2WFile AnimFile
        {
            get { return animFile; }
            set
            {
                try
                {
                    animFile = value;
                    anims = new Animations();
                    anims.LoadData(animFile);
                    modelAngle = new Vector3Df(startModelAngleWithAnim.X, startModelAngleWithAnim.Y, startModelAngle.Z);
                    RestartIrrThread();
                    selectAnimationToolStripMenuItem.DropDownItems.Clear();
                    for (int i = 0; i < Animations.AnimationNames.Count; i++)
                        selectAnimationToolStripMenuItem.DropDownItems.Add(Animations.AnimationNames[i].Key);
                    selectAnimationToolStripMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "AnimFile error:" + ex.Message);
                }
            }
        }

        #region private variables
        /// <summary>
        /// Thread variable for irrlicht thread.
        /// </summary>
        private Thread irrThread;

        private IrrlichtDevice device;
        private VideoDriver driver;
        private SceneManager smgr;
        private GUIEnvironment gui;

        /// <summary>
        /// The common data.
        /// </summary>
        private CommonData cdata = new CommonData();
        private Mesh mesh;
        private Rig rig;
        private Animations anims;

        //private static Quaternion modelAngle = new Quaternion(new Vertex3f(), 0);
        private Vector3Df modelPosition = new Vector3Df(0.0f);
        private Vector3Df startModelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);
        private Vector3Df startModelAngleWithAnim = new Vector3Df(180.0f, 270.0f, 0.0f);
        private Vector3Df modelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);
        private float scaleMul = 1;

        private bool modelAutorotating = true;
        //private static float angle_autorotate = 0;
        //private static float angle_autorotate_rad;
        private bool suppressTextureWarning = false;
        #endregion

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
                if (irrlichtPanel.IsDisposed)
                    throw new Exception("Form closed!");
                if (irrlichtPanel.InvokeRequired)
                    irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
                irrparam.DriverType = DriverType.Direct3D9;
                irrparam.BitsPerPixel = 16;

                device = IrrlichtDevice.CreateDevice(irrparam);

                if (device == null) throw new NullReferenceException("Could not create device for engine!");

                driver = device.VideoDriver;
                smgr   = device.SceneManager;
                gui    = device.GUIEnvironment;

                var animText = "";
                if (Animations.AnimationNames.Count > 0)
                    animText = "Animation: " + Animations.AnimationNames[selectedAnimIdx].Key;
                var mAnimText     = gui.AddStaticText(animText, new Recti(0, this.ClientSize.Height - 80, 100, this.ClientSize.Height - 70));
                var mPositionText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 70, 100, this.ClientSize.Height - 60));
                var mRotationText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 60, 100, this.ClientSize.Height - 50));
                var fpsText       = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 50, 100, this.ClientSize.Height - 40));
                var infoText      = gui.AddStaticText("[Space] - Reset\n[LMouse] - Rotate\n[MMouse] - Move\n[Wheel] - Zoom", new Recti(0, this.ClientSize.Height - 40, 100, this.ClientSize.Height));
                mAnimText.OverrideColor   = mPositionText.OverrideColor   = mRotationText.OverrideColor   = fpsText.OverrideColor   = infoText.OverrideColor   = new Color(255, 255, 255);
                mAnimText.BackgroundColor = mPositionText.BackgroundColor = mRotationText.BackgroundColor = fpsText.BackgroundColor = infoText.BackgroundColor = new Color(0, 0, 0);

                SkinnedMesh skinnedMesh = smgr.CreateSkinnedMesh();
                foreach (var meshBuffer in cdata.staticMesh.MeshBuffers)
                    skinnedMesh.AddMeshBuffer(meshBuffer);
                smgr.MeshManipulator.RecalculateNormals(skinnedMesh);
                if (RigFile != null)
                {
                    rig.Apply(skinnedMesh);
                    if (AnimFile != null)
                        anims.Apply(skinnedMesh);
                }
                skinnedMesh.SetDirty(HardwareBufferType.VertexAndIndex);
                skinnedMesh.FinalizeMeshPopulation();
                AnimatedMeshSceneNode node = smgr.AddAnimatedMeshSceneNode(skinnedMesh);

                if (node == null) throw new Exception("Could not load file!");

                node.Scale = new Vector3Df(3.0f);
                node.SetMaterialFlag(MaterialFlag.Lighting, false);
                SetMaterials(driver, node);

                CameraSceneNode camera = smgr.AddCameraSceneNode(null, new Vector3Df(node.BoundingBox.Radius*8, node.BoundingBox.Radius, 0), new Vector3Df(0, node.BoundingBox.Radius, 0));
                camera.NearValue = 0.001f;
                camera.FOV = 45 * CommonData.PI_OVER_180;
                scaleMul = node.BoundingBox.Radius / 4;

                var viewPort = driver.ViewPort;
                var lineMat = new Material();
                lineMat.Lighting = false;

                while (device.Run())
                {
                    driver.ViewPort = viewPort;
                    driver.BeginScene(ClearBufferFlag.All, new Color(100, 101, 140));

                    node.Position = modelPosition;
                    node.Rotation = modelAngle;
                    node.DebugDataVisible = DebugSceneType.Skeleton | DebugSceneType.BBox;
                    mPositionText.Text = $"X: {modelPosition.X.ToString("F2")} Y: {modelPosition.Y.ToString("F2")} Z: {modelPosition.Z.ToString("F2")}";
                    mRotationText.Text = $"Yaw: {modelAngle.Y.ToString("F2")} Roll: {modelAngle.Z.ToString("F2")}";
                    fpsText.Text = $"FPS: {driver.FPS}";

                    smgr.DrawAll();
                    gui.DrawAll();

                    driver.ViewPort = new Recti(this.ClientSize.Width - 100, this.ClientSize.Height - 80, this.ClientSize.Width, this.ClientSize.Height);
                    //driver.ClearBuffers(ClearBufferFlag.None);

                    driver.SetMaterial(lineMat);
                    var matrix = new Matrix(new Vector3Df(0, 0, 0), modelAngle);
                    driver.SetTransform(TransformationState.World, matrix);
                    matrix = matrix.BuildProjectionMatrixOrthoLH(100, 80, camera.NearValue, camera.FarValue);
                    driver.SetTransform(TransformationState.Projection, matrix);
                    matrix = matrix.BuildCameraLookAtMatrixLH(new Vector3Df(50, 0, 0), new Vector3Df(0, 0, 0), new Vector3Df(0, 1f, 0));
                    driver.SetTransform(TransformationState.View, matrix);
                    driver.Draw3DLine(0, 0, 0, 30f, 0, 0, Color.OpaqueGreen);
                    driver.Draw3DLine(0, 0, 0, 0, 30f, 0, Color.OpaqueBlue);
                    driver.Draw3DLine(0, 0, 0, 0, 0, 30f, Color.OpaqueRed);

                    driver.EndScene();
                }

                device.Drop();
            }
            catch (ThreadAbortException) { }
            catch (NullReferenceException) { }
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
        private void SetMaterials(VideoDriver driver, AnimatedMeshSceneNode node)
        {
            List<Material> materials = new List<Material>();
            //mat.Type = MaterialType.Solid;
            foreach (var materialInstance in cdata.materialInstances)
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
            for (int i = 0; i < cdata.meshInfos.Count; i++)
            {
                if (cdata.meshInfos[i].materialID < materials.Count)
                {
                    Material mat = materials[(int)cdata.meshInfos[i].materialID];
                    node.SetMaterialTexture(i, mat.GetTexture(i));
                }
            }
        }

        /// <summary>
        /// Try to get the texture file.
        /// </summary>
        private Texture GetTexture(VideoDriver driver, string handleFilename)
        {
            string texturePath = Path.Combine(Path.GetDirectoryName(meshFile.FileName),Path.GetFileNameWithoutExtension(handleFilename)).Replace("Bundle","TextureCache");
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

        #region event handlers
        private bool firstrun = true;
        private System.Windows.Forms.Timer resizeTimer = new System.Windows.Forms.Timer();

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

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (firstrun == false)
                resizeTimer.Start();
            else
                firstrun = false;
        }

        private void ResizeTimer(object sender, EventArgs e)
        {
            resizeTimer.Stop();
            if (irrThread != null)
            {
                RestartIrrThread();
            }
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
            else if (renderStarted && e.Button == MouseButtons.Middle)
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
                if (AnimFile == null)
                    modelAngle = new Vector3Df(startModelAngle.X, startModelAngle.Y, startModelAngle.Z);
                else
                    modelAngle = new Vector3Df(startModelAngleWithAnim.X, startModelAngleWithAnim.Y, startModelAngleWithAnim.Z);
                modelPosition = new Vector3Df(0.0f);
            }
        }
        #endregion

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sf = new SaveFileDialog())
            {
                sf.Filter = "Irrlicht mesh | *.irrm | Collada mesh | *.coll | STL Mesh | *.stl | OBJ Mesh | *.obj | PLY Mesh | *.ply | B3D Mesh | *.b3d";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    MeshWriterType mwt = MeshWriterType.Obj;
                    switch (Path.GetExtension(sf.FileName))
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
                    if (mw.WriteMesh(device.FileSystem.CreateWriteFile(sf.FileName), cdata.staticMesh, MeshWriterFlag.None))
                        MessageBox.Show(this,"Sucessfully wrote file!","WolvenKit",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Failed to write file!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadRigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // HACK: Hacky (shit) solution for automatic path finding
            /*var basePath = doc.File.FileName.Split(new string[] { "characters" }, StringSplitOptions.None)[0];
            var modelName = Path.GetFileName(doc.File.FileName).Split('_', '.')[3];
            var rigPath = $@"{basePath}characters\base_entities\{modelName}_base\{modelName}_base.w2rig";*/
            if (MessageBox.Show("Could not find .w2rig for model!\nWould you like to search for the rig manually?", "Rig not found!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Activate();
                var ofd = new OpenFileDialog();
                ofd.Filter = "Rig file|*.w2rig";
                if (ofd.ShowDialog() == DialogResult.OK)
                    RigFile = LoadDocument(ofd.FileName);
            }
        }

        private void loadAnimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Could not find .w2anims for model!\nWould you like to search for the animation manually (highly experimental)?", "Animation not found!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Activate();
                var ofd = new OpenFileDialog();
                ofd.Filter = "Animation file|*.w2anims";
                selectedAnimIdx = 0;
                if (ofd.ShowDialog() == DialogResult.OK)
                    AnimFile = LoadDocument(ofd.FileName);
            }
        }

        private int selectedAnimIdx = 0;
        private void selectAnimationToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            selectedAnimIdx = Animations.AnimationNames.FindIndex(kv => kv.Key.Equals(e.ClickedItem.Text));
            anims = new Animations();
            anims.SelectAnimation(AnimFile, selectedAnimIdx);
            modelAngle = new Vector3Df(startModelAngleWithAnim.X, startModelAngleWithAnim.Y, startModelAngle.Z);
            modelAutorotating = true;
            modelPosition = new Vector3Df(0.0f);
            RestartIrrThread();
        }
    }
}
