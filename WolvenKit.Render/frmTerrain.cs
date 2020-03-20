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


        private IrrlichtLime.Scene.TerrainSceneNode terrain;
        private IrrlichtLime.Video.Image heightmap;
        private TriangleSelector selector;

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

                heightmap = driver.CreateImage("Terrain\\basemap.bmp");

                terrain = smgr.AddTerrainSceneNode(
                        "Terrain\\basemap.bmp",
                        null,
                        -1,
                        new Vector3Df(0.0f)
                    );
                terrain.Scale = new Vector3Df(32, 5, 32);
                terrain.SetMaterialFlag(MaterialFlag.Lighting, false);

                terrain.SetMaterialTexture(0, driver.GetTexture("Terrain\\rockwall.jpg"));
                selector = smgr.CreateTerrainTriangleSelector(terrain, 0);

                var arrow = smgr.AddAnimatedMeshSceneNode(smgr.AddArrowMesh("arrow", new IrrlichtLime.Video.Color(255, 255, 0, 0), new IrrlichtLime.Video.Color(255, 0, 255, 0)), null);
                arrow.SetMaterialFlag(MaterialFlag.Lighting, false);
                arrow.Scale = new Vector3Df(100.0f);
                arrow.Rotation = new Vector3Df(0.0f, 0.0f, 180.0f);

                var cam = smgr.AddCameraSceneNodeFPS(null, 100.0f, 3.0f);
                cam.Position = new Vector3Df(-100.0f, 500.0f, 100.0f);
                cam.Target = new Vector3Df(0.0f);
                cam.FarValue = 10000;

                var irrTimer = device.Timer;
                var then = 0;
                var then30 = 0;



                while (device.Run())
                {
                    driver.BeginScene(true, true, new IrrlichtLime.Video.Color(255, 255, 255));

                    smgr.DrawAll();
                    gui.DrawAll();

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
            switch(e.KeyCode)
            {
                case Keys.Escape:
                {
                    irrThread.Abort();
                    this.Close();
                    break;
                }
            }
        }
    }
}
