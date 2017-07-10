using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;
using IrrlichtLime.GUI;

namespace WolvenKit.Render
{
    public partial class Bithack3D : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Thread irrThread;
        public Bithack3D()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // start an irrlicht thread
            ThreadStart irrThreadStart = new ThreadStart(startIrr);
            irrThread = new Thread(irrThreadStart);
            irrThread.Start();
        }


        public void startIrr()
        {
            IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
            if (irrlichtPanel.InvokeRequired)
                irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
            irrparam.DriverType = DriverType.Direct3D9;
            irrparam.BitsPerPixel = 16;

            IrrlichtDevice device = IrrlichtDevice.CreateDevice(irrparam);

            device.SetWindowCaption("Hello World! - Irrlicht Engine Demo");

            VideoDriver driver = device.VideoDriver;
            SceneManager smgr = device.SceneManager;
            GUIEnvironment gui = device.GUIEnvironment;

            gui.AddStaticText("Hello World! This is the Irrlicht Software renderer!",
                new Recti(10, 10, 260, 22), true);

            AnimatedMesh mesh = smgr.GetMesh("../../Media/sydney.md2");
            AnimatedMeshSceneNode node = smgr.AddAnimatedMeshSceneNode(mesh);

            if (node != null)
            {
                node.SetMaterialFlag(MaterialFlag.Lighting, false);
                node.SetMD2Animation(AnimationTypeMD2.Stand);
                node.SetMaterialTexture(0, driver.GetTexture("../../Media/sydney.bmp"));
            }

            smgr.AddCameraSceneNode(null, new Vector3Df(0, 30, -40), new Vector3Df(0, 5, 0));

            while (device.Run())
            {
                driver.BeginScene(ClearBufferFlag.All, new IrrlichtLime.Video.Color(100, 101, 140));

                smgr.DrawAll();
                gui.DrawAll();

                driver.EndScene();

                this.Invoke(new MethodInvoker(delegate { UpdateRichTextBox(); }));
            }

            device.Drop();
        }

        #region Common Data

        //private static Quaternion modelAngle = new Quaternion(new Vertex3f(), 0);
        private static Vector3Df modelPosition = new Vector3Df(0.0f, -1.5f, -2.0f);
        private static Vector3Df modelAngle = new Vector3Df();

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
            irrlichtPanel.Invalidate();
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
        private void Bithack3D_Closed(object sender, System.EventArgs e)
        {
            irrThread.Abort();
        }

        /*private static float currentLeftPosX = 0;
        private static float currentLeftPosY = 0;
        private static float currentRightPosX = 0;
        private static float currentRightPosY = 0;

        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (renderStarted && e.Button == MouseButtons.Left)
            {
                model_autorotating = false;
                // Around Y axis
                float deltaDirection = currentLeftPosX - e.X;
                modelAngle.Y = (modelAngle.Y - deltaDirection / 4.0f) % 360.0f;
                if (modelAngle.Y < 0)
                    modelAngle.Y = 360.0f + modelAngle.Y;
                currentLeftPosX = e.X;

                // Around X axis
                deltaDirection = currentLeftPosY - e.Y;
                modelAngle.X = (modelAngle.X - deltaDirection / 40.0f) % 360.0f;
                if (modelAngle.X < 0)
                    modelAngle.X = 360.0f + modelAngle.X;
                currentLeftPosY = e.Y;
            }
            else
            {
                currentLeftPosX = e.X;
                currentLeftPosY = e.Y;
            }
            if (renderStarted && e.Button == MouseButtons.Right)
            {
                model_autorotating = false;
                float deltaDirection = currentRightPosX - e.X;
                modelPosition.X = modelPosition.X - deltaDirection / 100;
                currentRightPosX = e.X;

                deltaDirection = currentRightPosY - e.Y;
                modelPosition.Y = modelPosition.Y + deltaDirection / 100;
                currentRightPosY = e.Y;
            }
            else
            {
                currentRightPosX = e.X;
                currentRightPosY = e.Y;
            }
        }

        private void Bithack3D_MouseWheel(object sender, MouseEventArgs e)
        {
            if (renderStarted)
                modelPosition.Z = modelPosition.Z + (float)e.Delta / 1000.0f;
        }

        private void Bithack3D_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Restart autorotation
                model_autorotating = true;
                modelAngle.X = modelAngle.Y = modelAngle.Z = 0;
                modelPosition.X = 0;
                modelPosition.Y = -1.5f;
                modelPosition.Z = -2.0f;
            }
        }*/
        #endregion
    }
}
