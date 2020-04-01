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
        private IrrlichtLime.Scene.SceneNode outnode;

        private Vector3Df modelPosition = new Vector3Df(0.0f);
        private Vector3Df modelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);

        private bool renderStarted = false;

        private float scaleMul = 1;

        public frmTerrain()
        {
            InitializeComponent();
            Cursor.Hide();
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
                //Setup
                IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
                if (irrlichtPanel.IsDisposed)
                    throw new Exception("Form closed!");
                if (irrlichtPanel.InvokeRequired)
                    irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
                irrparam.DriverType = DriverType.Direct3D9;
                irrparam.DriverType = DriverType.OpenGL;
                irrparam.BitsPerPixel = 16;

                device = IrrlichtDevice.CreateDevice(irrparam);

                if (device == null) throw new NullReferenceException("Could not create device for engine!");

                driver = device.VideoDriver;
                smgr = device.SceneManager;
                gui = device.GUIEnvironment;

                var cam = smgr.AddCameraSceneNode(null);
                cam.TargetAndRotationBinding = true;
                cam.Position = new Vector3Df(-100.0f, 500.0f, 100.0f);
                cam.Target = new Vector3Df(0.0f);
                cam.FarValue = 42000.0f;

                device.CursorControl.Visible = false;

                //Terrain
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

                //Skybox and skydome
                driver.SetTextureCreationFlag(TextureCreationFlag.CreateMipMaps, false);
                /*var box = smgr.AddSkyBoxSceneNode(
                    ("Terrain\\irrlicht2_up.jpg"),
                    ("Terrain\\irrlicht2_dn.jpg"),
                    ("Terrain\\irrlicht2_lf.jpg"),
                    ("Terrain\\irrlicht2_rt.jpg"),
                    ("Terrain\\irrlicht2_ft.jpg"),
                    ("Terrain\\irrlicht2_bk.jpg"));
                box.Visible = true;*/
                var dome = smgr.AddSkyDomeSceneNode(driver.GetTexture("Terrain\\skydome.jpg"), 16, 8, 0.95f, 2.0f);
                dome.Visible = true;
                driver.SetTextureCreationFlag(TextureCreationFlag.CreateMipMaps, true);



                var irrTimer = device.Timer;
                var then = 0;
                var then30 = 0;

                device.CursorControl.Visible = false;

                Vector2Df lastcurr = new Vector2Df(0f);
                uint dt = 0;
                while (device.Run())
                {
                    driver.BeginScene(ClearBufferFlag.All);


                    // move the arrow to the nearest vertex ...
                    IrrlichtLime.Core.Vector2Di center = new IrrlichtLime.Core.Vector2Di(irrlichtPanel.Width/2, irrlichtPanel.Height/2);
                    Line3Df ray = smgr.SceneCollisionManager.GetRayFromScreenCoordinates(center, cam);
                    Vector3Df pos;
                    Triangle3Df Tri;
                    var curr = device.CursorControl.RelativePosition;

                    // Threshold and periodical check so we don't spin around due to float conversions
                    if (device.Timer.Time > dt && curr.GetDistanceFrom(lastcurr) > 0.01f)
                    {
                        Line3Df cursor_ray = smgr.SceneCollisionManager
                            .GetRayFromScreenCoordinates(new Vector2Di((int)(curr.X * irrlichtPanel.Width),(int)(curr.Y * irrlichtPanel.Height)), cam);

                        smgr.ActiveCamera.Target = cursor_ray.Middle;
                        dt = device.Timer.Time + 30;
                        lastcurr = curr;
                        device.CursorControl.Position = center;
                    }

                    if (smgr.SceneCollisionManager.GetCollisionPoint(ray, selector, out pos, out Tri, out outnode))
                    {
                        var scale = 32; // terrain is scaled 32X
                        var size = 512; // heightmap is 512x512 pixels
                        var x = (pos.X / scale);
                        var z = (pos.Z / scale);
                        var index = x * size + z;

                        x *= scale;
                        z *= scale;

                        arrow.Position = new Vector3Df(x, terrain.GetHeight(x, z) + 100, z);                        
                    }

                    smgr.DrawAll();
                    gui.DrawAll();

                    driver.EndScene();

                    //device.CursorControl.Position = new Vector2Di(irrlichtPanel.
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



        bool firstMouse = true;
        float lastX;
        float lastY;
        double yaw;
        double pitch;

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
            var cam = smgr.ActiveCamera;
            float cameraspeed = 100f;
            switch (e.KeyCode)
            {
                case Keys.Escape:
                {
                    device.Close();
                    irrThread.Abort();
                    this.Close();
                    break;
                }
                case Keys.W:
                {
                    var vec = (cam.Target - cam.Position).Normalize() * cameraspeed;
                    cam.Position += vec;
                    cam.Target += vec;
                    break;
                }
                case Keys.S:
                {
                    var vec = (cam.Target - cam.Position).Normalize() * cameraspeed;
                    cam.Position -= vec;
                    cam.Target -= vec;
                    break;
                }
                case Keys.A:
                {
                    var vec = (cam.Target - cam.Position).Normalize().DotProduct(cam.Target.Normalize()) * cameraspeed;
                    cam.Position -= vec;
                    cam.Target -= vec;
                    break;
                }
                case Keys.D:
                {
                    var vec = (cam.Target - cam.Position).Normalize().DotProduct(cam.Target.Normalize()) *cameraspeed;
                    cam.Position += vec;
                    cam.Target += vec;
                    break;
                }
                case Keys.P:
                {
                    Console.WriteLine("--------- DEBUG ---------");
                    Console.WriteLine($"[DEBUG] Camera position - (X - {cam.Position.X}, Y - {cam.Position.Y}, Z - {cam.Position.Z})");
                    Console.WriteLine("--------- DEBUG ---------");
                    break;
                }
            }
        }
    }
}
