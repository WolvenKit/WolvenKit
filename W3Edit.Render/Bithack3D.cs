using System;
using System.Windows.Forms;

using OpenGL;
using System.IO;

namespace W3Edit.Render
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
            RenderControl_Render_GLSL(sender, e);
        }

        // Disposing resources allocated in RenderControl_ContextCreated
        private void RenderControl_ContextDestroying(object sender, GlControlEventArgs e)
        {
            RenderControl_ContextDestroying_GLSL(sender, e);
        }

        #region Common Data

        private static float angle;
        private static float angle_rad;
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
            modelMatrix.Translate(new Vertex3f(0.0f, -1.5f, -2.0f));
            modelMatrix.Scale(new Vertex3f(0.2f, 0.2f, 0.2f));

            Gl.Viewport(0, 0, control.Width, control.Height);
            Gl.ClearColor(0.05f, 0.05f, 0.05f, 1.0f);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            modelShader.Use();
            //viewMatrix.RotateY(angle);
            //viewMatrix.LookAtDirection(new Vertex3f(0.0f, 0.0f, 3.0f), new Vertex3f(-4.37113883e-08f, 0.0f, 2.0f), new Vertex3f(0.0f, 1.0f, 0.0f));
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

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Change camera rotation
            angle = (angle + 4f) % 360.0f;
            angle_rad = angle * PI_OVER_180;

            // Issue a new frame after this render
            glControl1.Invalidate();
        }
    }
}
