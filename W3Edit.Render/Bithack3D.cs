using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenGL;

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
            GlControl glControl = (GlControl)sender;

            RenderControl_ContextCreated_ES(sender, e);
        }

        private void RenderControl_Render(object sender, GlControlEventArgs e)
        {
            RenderControl_Render_ES(sender, e);
        }

        private void RenderControl_ContextDestroying(object sender, GlControlEventArgs e)
        {
            // Here you can dispose resources allocated in RenderControl_ContextCreated
            RenderControl_ContextDestroying_ES(sender, e);
        }

        #region Common Data

        private static float angle;
        private static float angle_rad;
        private const float PI_OVER_180 = (float)Math.PI / 180.0f;

        /// <summary>
        /// Vertex position array.
        /// </summary>
        private static readonly float[] _ArrayPosition = new float[] {
            -0.5f, -0.5f, -0.5f,
             0.5f, -0.5f, -0.5f,
             0.5f,  0.5f, -0.5f,
             0.5f,  0.5f, -0.5f,
            -0.5f,  0.5f, -0.5f,
            -0.5f, -0.5f, -0.5f,

            -0.5f, -0.5f,  0.5f,
             0.5f, -0.5f,  0.5f,
             0.5f,  0.5f,  0.5f,
             0.5f,  0.5f,  0.5f,
            -0.5f,  0.5f,  0.5f,
            -0.5f, -0.5f,  0.5f,

            -0.5f,  0.5f,  0.5f,
            -0.5f,  0.5f, -0.5f,
            -0.5f, -0.5f, -0.5f,
            -0.5f, -0.5f, -0.5f,
            -0.5f, -0.5f,  0.5f,
            -0.5f,  0.5f,  0.5f,

             0.5f,  0.5f,  0.5f,
             0.5f,  0.5f, -0.5f,
             0.5f, -0.5f, -0.5f,
             0.5f, -0.5f, -0.5f,
             0.5f, -0.5f,  0.5f,
             0.5f,  0.5f,  0.5f,

            -0.5f, -0.5f, -0.5f,
             0.5f, -0.5f, -0.5f,
             0.5f, -0.5f,  0.5f,
             0.5f, -0.5f,  0.5f,
            -0.5f, -0.5f,  0.5f,
            -0.5f, -0.5f, -0.5f,

            -0.5f,  0.5f, -0.5f,
             0.5f,  0.5f, -0.5f,
             0.5f,  0.5f,  0.5f,
             0.5f,  0.5f,  0.5f,
            -0.5f,  0.5f,  0.5f,
            -0.5f,  0.5f, -0.5f
        };

        /// <summary>
        /// Vertex color array.
        /// </summary>
        private static readonly float[] _ArrayColor = new float[] {
            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,
            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,

            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,
            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,

            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,
            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,

            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,
            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,

            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,
            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,

            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,
            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f,
        };

        #endregion

        #region ES Resources

        private void RenderControl_Render_ES(object sender, GlControlEventArgs e)
        {
            Control control = (Control)sender;
            PerspectiveProjectionMatrix projectionMatrix = new PerspectiveProjectionMatrix(45.0f, (float)control.Width/(float)control.Height, 0.1f, 100.0f);
            ModelMatrix viewMatrix = new ModelMatrix();
            ModelMatrix modelMatrix = new ModelMatrix();

            // Move camera
            viewMatrix.Translate(new Vertex3f(0.0f, 0.0f, -2.0f));
            // Animate triangle
            /*modelMatrix.LookAtDirection(
                new Vertex3f(0.0f, 0.0f, 0.0f),
                new Vertex3f(
                    (float)Math.Sin(angle_rad),
                    0.0f,
                    (float)Math.Cos(angle_rad)
                ),
                new Vertex3f(0.0f, 1.0f, 0.0f)
            );*/
            //Quaternion Q = new Quaternion(new Vertex3f(0.0f, 1.0f, 0.0f), angle);
            modelMatrix.RotateZ(angle);
            modelMatrix.RotateY(angle);
            //modelMatrix.Translate(Math.Cos(theta), Math.Sin(theta));
            //modelMatrix.RotateY(theta);

            Gl.UseProgram(Program_Shader);

            Gl.Viewport(0, 0, control.Width, control.Height);
            Gl.Enable(EnableCap.DepthTest);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            using (MemoryLock arrayPosition = new MemoryLock(_ArrayPosition))
            using (MemoryLock arrayColor = new MemoryLock(_ArrayColor))
            {
                Gl.VertexAttribPointer((uint)Program_Location_aPosition, 3, Gl.FLOAT, false, 0, arrayPosition.Address);
                Gl.EnableVertexAttribArray((uint)Program_Location_aPosition);

                Gl.VertexAttribPointer((uint)Program_Location_aColor, 3, Gl.FLOAT, false, 0, arrayColor.Address);
                Gl.EnableVertexAttribArray((uint)Program_Location_aColor);

                Gl.UniformMatrix4(Program_Location_uProjection, 1, false, projectionMatrix.ToArray());
                Gl.UniformMatrix4(Program_Location_uView, 1, false, viewMatrix.ToArray());
                Gl.UniformMatrix4(Program_Location_uModel, 1, false, modelMatrix.ToArray());

                Gl.DrawArrays(PrimitiveType.Triangles, 0, 36);
            }
        }

        private void RenderControl_ContextCreated_ES(object sender, GlControlEventArgs e)
        {
            StringBuilder infolog = new StringBuilder(1024);
            int infologLength;
            int compiled;

            infolog.EnsureCapacity(1024);

            // Vertex shader
            uint vertexShader = Gl.CreateShader(Gl.VERTEX_SHADER);
            Gl.ShaderSource(vertexShader, _Es2_ShaderVertexSource);
            Gl.CompileShader(vertexShader);
            Gl.GetShader(vertexShader, Gl.COMPILE_STATUS, out compiled);
            if (compiled == 0)
            {
                Gl.GetShaderInfoLog(vertexShader, 1024, out infologLength, infolog);
            }

            // Fragment shader
            uint fragmentShader = Gl.CreateShader(Gl.FRAGMENT_SHADER);
            Gl.ShaderSource(fragmentShader, _Es2_ShaderFragmentSource);
            Gl.CompileShader(fragmentShader);
            Gl.GetShader(fragmentShader, Gl.COMPILE_STATUS, out compiled);
            if (compiled == 0)
            {
                Gl.GetShaderInfoLog(fragmentShader, 1024, out infologLength, infolog);
            }

            // Program
            Program_Shader = Gl.CreateProgram();
            Gl.AttachShader(Program_Shader, vertexShader);
            Gl.AttachShader(Program_Shader, fragmentShader);
            Gl.LinkProgram(Program_Shader);

            int linked;
            Gl.GetProgram(Program_Shader, Gl.LINK_STATUS, out linked);

            if (linked == 0)
            {
                Gl.GetProgramInfoLog(Program_Shader, 1024, out infologLength, infolog);
            }

            Program_Location_uProjection = Gl.GetUniformLocation(Program_Shader, "uProjection");
            Program_Location_uView = Gl.GetUniformLocation(Program_Shader, "uView");
            Program_Location_uModel = Gl.GetUniformLocation(Program_Shader, "uModel");
            Program_Location_aPosition = Gl.GetAttribLocation(Program_Shader, "aPosition");
            Program_Location_aColor = Gl.GetAttribLocation(Program_Shader, "aColor");
        }

        private void RenderControl_ContextDestroying_ES(object sender, OpenGL.GlControlEventArgs e)
        {
            if (Program_Shader != 0)
                Gl.DeleteProgram(Program_Shader);
            Program_Shader = 0;
        }

        private uint Program_Shader;
        private int Program_Location_aPosition;
        private int Program_Location_aColor;
        private int Program_Location_uProjection;
        private int Program_Location_uView;
        private int Program_Location_uModel;

        private readonly string[] _Es2_ShaderVertexSource = new string[] {
            "uniform mat4 uProjection;\n",
            "uniform mat4 uView;\n",
            "uniform mat4 uModel;\n",
            "attribute vec3 aPosition;\n",
            "attribute vec3 aColor;\n",
            "varying vec3 vColor;\n",
            "void main() {\n",
            "	gl_Position = uProjection*uView*uModel*vec4(aPosition, 1.0);\n",
            "	vColor = aColor;\n",
            "}\n"
        };

        private readonly string[] _Es2_ShaderFragmentSource = new string[] {
            "varying vec3 vColor;\n",
            "void main() {\n",
            "	gl_FragColor = vec4(vColor, 1.0);\n",
            "}\n"
        };

        #endregion

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Change triangle rotation
            angle = (angle + 1f) % 360.0f;
            angle_rad = angle * PI_OVER_180;

            // Issue a new frame after this render
            glControl1.Invalidate();
        }
    }
}
