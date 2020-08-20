using System;
using System.IO;
using System.Windows.Forms;
using OpenGL;

namespace WolvenKit.Render
{
    public partial class Bithack3D : Form
    {
        public Bithack3D()
        {
            InitializeComponent();
        }

        private void RenderControl_ContextCreated(object sender, GlControlEventArgs e)
        {
            RenderControl_ContextCreated_GLSL(sender, e);
        }

        private void RenderControl_Render(object sender, GlControlEventArgs e)
        {
            renderStarted = true;
            RenderControl_Render_GLSL(sender, e);
            UpdateRichTextBox();
        }

        // Disposing resources allocated in RenderControl_ContextCreated
        private void RenderControl_ContextDestroying(object sender, GlControlEventArgs e)
        {
            RenderControl_ContextDestroying_GLSL(sender, e);
        }

        #region Common Data

        private static bool renderStarted = false;

        //private static Quaternion modelAngle = new Quaternion(new Vertex3f(), 0);
        private static Vertex3f modelPosition = new Vertex3f(0.0f, -1.5f, -2.0f);
        private static Vertex3f modelAngle = new Vertex3f();

        private static bool model_autorotating;
        //private static float angle_autorotate = 0;
        //private static float angle_autorotate_rad;
        private const float PI_OVER_180 = (float)Math.PI / 180.0f;

        private Shader modelShader;
        private Model modelNanosuit;

        #endregion

        #region GLSL Resources

        private void RenderControl_Render_GLSL(object sender, GlControlEventArgs e)
        {
            Control control = (Control)sender;

            PerspectiveProjectionMatrix projectionMatrix = new PerspectiveProjectionMatrix(45.0f, (float)control.Width/(float)control.Height, 0.1f, 100.0f);
            ModelMatrix viewMatrix = new ModelMatrix();
            ModelMatrix modelMatrix = new ModelMatrix();
            modelMatrix.Translate(new Vertex3f(modelPosition.X, modelPosition.Y, modelPosition.Z));
            modelMatrix.Scale(new Vertex3f(0.2f, 0.2f, 0.2f));

            Gl.Viewport(0, 0, control.Width, control.Height);
            Gl.ClearColor(0.05f, 0.05f, 0.05f, 1.0f);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            modelShader.Use();
            modelMatrix.RotateX(modelAngle.X);
            modelMatrix.RotateY(modelAngle.Y);
            modelMatrix.RotateZ(modelAngle.Z);
            //viewMatrix.Translate(new Vertex3f(-2.0f * (float)Math.Sin(modelAngle.Y * PI_OVER_180), 0.0f, -2.0f*(float)Math.Cos(modelAngle.Y*PI_OVER_180)));
            Gl.UniformMatrix4(modelShader.uLocation_Projection, 1, false, projectionMatrix.ToArray());
            Gl.UniformMatrix4(modelShader.uLocation_View, 1, false, viewMatrix.ToArray());
            Gl.UniformMatrix4(modelShader.uLocation_Model, 1, false, modelMatrix.ToArray());

            modelNanosuit.Draw(modelShader);
        }

        private void RenderControl_ContextCreated_GLSL(object sender, GlControlEventArgs e)
        {
            // Loading shaders, initing OpenGL
            modelShader = new Shader(Shaders.Model.VertexSource, Shaders.Model.FragmentSource);
            modelShader.uLocation_Projection = Gl.GetUniformLocation(modelShader.Program, Shaders.Model.uLocation_Projection);
            modelShader.uLocation_View = Gl.GetUniformLocation(modelShader.Program, Shaders.Model.uLocation_View);
            modelShader.uLocation_Model = Gl.GetUniformLocation(modelShader.Program, Shaders.Model.uLocation_Model);
            Gl.Enable(EnableCap.DepthTest);

            // By default autorotate model
            model_autorotating = true;

            // OpenFileDialog for importing 3D models
            OpenFileDialog open3dModel = new OpenFileDialog();
            open3dModel.InitialDirectory = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Models"));
            // If dir not found then use exe dir
            if( Directory.Exists(open3dModel.InitialDirectory) == false )
            {
                open3dModel.InitialDirectory = Environment.CurrentDirectory;
            }

            if (open3dModel.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    modelNanosuit = new Model( Path.GetFullPath(open3dModel.FileName).Replace(@"\", "/") );
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
            }
        }

        private void RenderControl_ContextDestroying_GLSL(object sender, OpenGL.GlControlEventArgs e)
        {
            if (modelShader.Program != 0)
                Gl.DeleteProgram(modelShader.Program);
            modelShader.Program = 0;

            if (modelNanosuit != null)
            {
                for (int i = 0; i < modelNanosuit.meshes.Count; i++)
                {
                    Gl.DeleteVertexArrays(modelNanosuit.meshes[i].VAO);
                    Gl.DeleteBuffers(modelNanosuit.meshes[i].VBO);
                    Gl.DeleteBuffers(modelNanosuit.meshes[i].EBO);
                }
            }

            if (modelNanosuit != null)
            {
                for (int i = 0; i < modelNanosuit.textures_loaded.Count; i++)
                {
                    Gl.DeleteTextures(modelNanosuit.textures_loaded[i].id);
                }
            }
        }

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
            glControl1.Invalidate();
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
        private static float currentLeftPosX = 0;
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
                modelAngle.Y = (modelAngle.Y - deltaDirection/4.0f) % 360.0f;
                if (modelAngle.Y < 0)
                    modelAngle.Y = 360.0f + modelAngle.Y;
                currentLeftPosX = e.X;

                // Around X axis
                deltaDirection = currentLeftPosY - e.Y;
                modelAngle.X = (modelAngle.X - deltaDirection/40.0f) % 360.0f;
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
                modelPosition.X = modelPosition.X - deltaDirection/100;
                currentRightPosX = e.X;

                deltaDirection = currentRightPosY - e.Y;
                modelPosition.Y = modelPosition.Y + deltaDirection/100;
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
                modelPosition.Z = modelPosition.Z + (float)e.Delta/1000.0f;
        }

        private void Bithack3D_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                // Restart autorotation
                model_autorotating = true;
                modelAngle.X = modelAngle.Y = modelAngle.Z = 0;
                modelPosition.X = 0;
                modelPosition.Y = -1.5f;
                modelPosition.Z = -2.0f;
            }
        }
        #endregion
    }
}
