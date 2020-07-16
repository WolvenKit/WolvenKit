using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;
using IrrlichtLime.GUI;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;


namespace WolvenKit.Render
{
    using CR2W;
    using CR2W.Types;
    using Common.Services;

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

        public RenderHelper renderHelper { get; set; }

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
                    mesh = new WKMesh(cdata);
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
                    
                    RestartIrrThread();
                    setupRenderContextMenu();
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

        private static IrrlichtDevice device = null;
        private VideoDriver driver;
        private SceneManager smgr;
        private GUIEnvironment gui;

        private static SceneNode node = null;
        private SkinnedMesh skinnedMesh;

        /// <summary>
        /// The common data.
        /// </summary>
        private CommonData cdata = new CommonData();
        private WKMesh mesh;
        private Rig rig;
        private Animations anims;
        private int currAnimIdx = -1;
        private ILoggerService Logger;

        //private static Quaternion modelAngle = new Quaternion(new Vertex3f(), 0);
        private Vector3Df modelPosition = new Vector3Df(0.0f);
        private Vector3Df modelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);
        private Vector3Df startModelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);
        //private Vector3Df startModelAngleWithAnim = new Vector3Df(180.0f, 270.0f, 0.0f);
        private Vector3Df startModelAngleWithAnim = new Vector3Df(0.0f, 0.0f, 0.0f);
        private float scaleMul = 1;

        private bool modelAutorotating = true;
        private bool suppressTextureWarning = false;
        private static bool useLight = false;
        #endregion

        /// <summary>
        /// OnLoad render form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRender_Load(object sender, EventArgs e)
        {
            Logger = renderHelper.getLogger();
            Logger.LogString("Render Init", Logtype.Normal);

            resizeTimer.Tick += ResizeTimer;
            resizeTimer.Interval = 1000;

            // start an irrlicht thread
            StartIrrThread();
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
            skinnedMesh.Drop();
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
                device.OnEvent += new IrrlichtDevice.EventHandler(device_OnEvent);

                driver = device.VideoDriver;
                smgr = device.SceneManager;
                gui = device.GUIEnvironment;

                var animText = "";
                if (Animations.AnimationNames.Count > 0 && currAnimIdx != -1)
                    animText = "Animation: " + Animations.AnimationNames[currAnimIdx].Key;

                var mAnimText = gui.AddStaticText(animText, new Recti(0, this.ClientSize.Height - 80, 100, this.ClientSize.Height - 70));
                var mPositionText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 70, 100, this.ClientSize.Height - 60));
                var mRotationText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 60, 100, this.ClientSize.Height - 50));
                var fpsText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 50, 100, this.ClientSize.Height - 40));
                var infoText = gui.AddStaticText("[Space] - Reset\n[LMouse] - Rotate\n[MMouse] - Move\n[Wheel] - Zoom", new Recti(0, this.ClientSize.Height - 40, 100, this.ClientSize.Height));
                mAnimText.OverrideColor = mPositionText.OverrideColor = mRotationText.OverrideColor = fpsText.OverrideColor = infoText.OverrideColor = new Color(255, 255, 255);
                mAnimText.BackgroundColor = mPositionText.BackgroundColor = mRotationText.BackgroundColor = fpsText.BackgroundColor = infoText.BackgroundColor = new Color(0, 0, 0);

                skinnedMesh = smgr.CreateSkinnedMesh();
                foreach (var meshBuffer in cdata.staticMesh.MeshBuffers)
                    skinnedMesh.AddMeshBuffer(meshBuffer);
                smgr.MeshManipulator.RecalculateNormals(skinnedMesh);
                if (RigFile != null)
                {
                    rig.Apply(skinnedMesh);
                    if (AnimFile != null && currAnimIdx != -1)
                        anims.Apply(skinnedMesh);
                }
                skinnedMesh.SetDirty(HardwareBufferType.VertexAndIndex);
                skinnedMesh.FinalizeMeshPopulation();

                AnimatedMeshSceneNode n = smgr.AddAnimatedMeshSceneNode(skinnedMesh);
                if (n == null)
                {
                    throw new Exception("Could not create animated scene node!");
                }
                else
                {
                    node = n;
                }

                node.Scale = new Vector3Df(3.0f);
                node.SetMaterialFlag(MaterialFlag.Lighting, false);

                SetMaterials(driver);

                CameraSceneNode camera = smgr.AddCameraSceneNode(null, new Vector3Df(node.BoundingBox.Radius * 8, node.BoundingBox.Radius, 0), new Vector3Df(0, node.BoundingBox.Radius, 0));
                camera.NearValue = 0.001f;
                camera.FOV = 45 * CommonData.PI_OVER_180;
                scaleMul = node.BoundingBox.Radius / 4;

                var viewPort = driver.ViewPort;
                var lineMat = new Material
                {
                    Lighting = false
                };

                resetDebugViewMenu();                                                       //reset debug view featchers
                smgr.Attributes.SetValue(SceneParameters.DebugNormalLength, scaleMul / 2);  //calculate normals length

                // main drawing loop
                while (device.Run() && driver != null)
                {
                    if (this.Visible)
                    {
                        driver.ViewPort = viewPort;
                        driver.BeginScene(ClearBufferFlag.All, new Color(100, 101, 140));

                        node.Position = modelPosition;
                        node.Rotation = modelAngle;

                        //update info box
                        mPositionText.Text = $"X: {modelPosition.X.ToString("F2")} Y: {modelPosition.Y.ToString("F2")} Z: {modelPosition.Z.ToString("F2")}";
                        mRotationText.Text = $"Yaw: {modelAngle.Y.ToString("F2")} Roll: {modelAngle.Z.ToString("F2")}";
                        fpsText.Text = $"FPS: {driver.FPS}";

                        smgr.DrawAll();
                        gui.DrawAll();


                        // draw xyz axis right bottom
                        driver.ViewPort = new Recti(this.ClientSize.Width - 100, this.ClientSize.Height - 80, this.ClientSize.Width, this.ClientSize.Height);

                        driver.SetMaterial(lineMat);
                        var matrix = new Matrix(new Vector3Df(0, 0, 0), modelAngle);
                        driver.SetTransform(TransformationState.World, matrix);
                        matrix = matrix.BuildProjectionMatrixOrthoLH(100, 80, camera.NearValue, camera.FarValue);
                        driver.SetTransform(TransformationState.Projection, matrix);
                        matrix = matrix.BuildCameraLookAtMatrixLH(new Vector3Df(50, 0, 0), new Vector3Df(0, 0, 0), new Vector3Df(0, 1f, 0));
                        driver.SetTransform(TransformationState.View, matrix);
                        driver.Draw3DLine(0, 0, 0, 30f, 0, 0, Color.SolidGreen);
                        driver.Draw3DLine(0, 0, 0, 0, 30f, 0, Color.SolidBlue);
                        driver.Draw3DLine(0, 0, 0, 0, 0, 30f, Color.SolidRed);

                        driver.EndScene();
                    }
                    else
                        device.Yield();
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
        private void SetMaterials(VideoDriver driver)//, AnimatedMeshSceneNode node)
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
                            Texture diffTexture = GetTexture(driver, (material as CHandle).DepotPath);
                            mat.SetTexture(0, diffTexture);
                            break;
                        case "Normal":
                            Texture normTexture = GetTexture(driver, (material as CHandle).DepotPath);
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
            string modPath = renderHelper.getW3Mod().ModDirectory;
            string texturePath = Path.ChangeExtension(Path.GetFullPath(modPath + "\\Bundle\\" + handleFilename)
                .Replace("Mod\\Bundle", "Raw\\Mod")
                .Replace("DLC\\Bundle", "Raw\\DLC"), null);

            string[] textureFileExtensions = { ".dds", ".bmp", ".tga", ".jpg", ".jpeg", ".png", ".xbm" };
            Texture texture = null;
            foreach (var textureFileExtension in textureFileExtensions)
            {
                var texturepath = Path.ChangeExtension(texturePath, textureFileExtension);
                if (File.Exists(texturepath))
                {
                    texture = driver.GetTexture(texturePath + textureFileExtension);
                    if (texture != null)
                        return texture; ;
                }
            }


            string dlcPath = renderHelper.getW3Mod().DlcDirectory;
            string texturePath1 = Path.ChangeExtension(Path.GetFullPath(dlcPath + "\\Bundle\\" + handleFilename)
                .Replace("Mod\\Bundle", "Raw\\Mod")
                .Replace("DLC\\Bundle", "Raw\\DLC"), null);
                        
            texture = null;
            foreach (var textureFileExtension in textureFileExtensions)
            {
                var texturepath = Path.ChangeExtension(texturePath, textureFileExtension);
                if (File.Exists(texturepath))
                {
                    texture = driver.GetTexture(texturePath + textureFileExtension);
                    if (texture != null) break;
                }
            }
            //ImageUtility.Xbm2Dds();
            if (texture == null && !suppressTextureWarning)
            {
                // try to extract from game files




                suppressTextureWarning = true;
                Logger.LogString($"Could not parse texture: {texturePath} or {texturePath1}", Logtype.Error);
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

        }

        
    }
}
