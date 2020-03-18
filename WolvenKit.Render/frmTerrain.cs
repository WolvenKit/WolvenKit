using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.GUI;
using IrrlichtLime.Scene;
using IrrlichtLime.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WolvenKit.Render
{
    public partial class frmTerrain : DockContent
    {
        /// <summary>
        /// Thread variable for irrlicht thread.
        /// </summary>
        private Thread irrThread;

        private IrrlichtDevice device;
        private VideoDriver driver;
        private SceneManager smgr;
        private GUIEnvironment gui;

        private Vector3Df modelPosition = new Vector3Df(0.0f);
        private Vector3Df modelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);

        private bool renderStarted = false;

        private float scaleMul = 1;

        public frmTerrain()
        {
            InitializeComponent();
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
                if (irrlichtPanel.IsDisposed)
                    throw new Exception("Form closed!");
                if (irrlichtPanel.InvokeRequired)
                    irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
                irrparam.DriverType = DriverType.Direct3D9;
                irrparam.BitsPerPixel = 16;

                device = IrrlichtDevice.CreateDevice(irrparam);

                if (device == null) throw new NullReferenceException("Could not create device for engine!");

                driver = device.VideoDriver;
                smgr = device.SceneManager;
                gui = device.GUIEnvironment;

                var mPositionText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 70, 100, this.ClientSize.Height - 60));
                var mRotationText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 60, 100, this.ClientSize.Height - 50));
                var fpsText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 50, 100, this.ClientSize.Height - 40));
                var infoText = gui.AddStaticText("[Space] - Reset\n[LMouse] - Rotate\n[MMouse] - Move\n[Wheel] - Zoom", new Recti(0, this.ClientSize.Height - 40, 100, this.ClientSize.Height));


                //TODO: Add terrain here
                Terrain.Terrain terr = new Terrain.Terrain();
                var node = terr.LoadTerrain(device, "D:\\Repos\\Irrlicht-Terrain-Editor\\basemap.bmp", "D:\\Repos\\Irrlicht-Terrain-Editor\\rockwall.jpg");


                if (node == null) throw new Exception("Could not load file!");

                node.Scale = new Vector3Df(3.0f);
                node.SetMaterialFlag(MaterialFlag.Lighting, false);

                CameraSceneNode camera = smgr.AddCameraSceneNode(null, new Vector3Df(node.BoundingBox.Radius * 8, node.BoundingBox.Radius, 0), new Vector3Df(0, node.BoundingBox.Radius, 0));
                camera.NearValue = 0.001f;
                camera.FOV = 45 * CommonData.PI_OVER_180;
                scaleMul = node.BoundingBox.Radius / 4;

                var viewPort = driver.ViewPort;
                var lineMat = new Material();
                lineMat.Lighting = false;

                renderStarted = true;

                while (device.Run())
                {
                    driver.ViewPort = viewPort;
                    driver.BeginScene(ClearBufferFlag.All, new IrrlichtLime.Video.Color(100, 101, 140));

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
                    driver.Draw3DLine(0, 0, 0, 30f, 0, 0, IrrlichtLime.Video.Color.OpaqueGreen);
                    driver.Draw3DLine(0, 0, 0, 0, 30f, 0, IrrlichtLime.Video.Color.OpaqueBlue);
                    driver.Draw3DLine(0, 0, 0, 0, 0, 30f, IrrlichtLime.Video.Color.OpaqueRed);

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

        private void frmTerrain_Load(object sender, EventArgs e)
        {
            StartIrrThread();
        }

        private void irrlichtPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Bithack3D_MouseWheel(object sender, MouseEventArgs e)
        {
            if (renderStarted)
                modelPosition.X = modelPosition.X + (float)e.Delta / 1000.0f;
        }

        private void frmTerrain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                modelPosition = new Vector3Df(0.0f);
            }
        }
    }
}
