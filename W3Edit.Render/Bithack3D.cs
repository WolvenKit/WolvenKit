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

            if (Gl.CurrentVersion.Api == KhronosVersion.ApiGles2)
                RenderControl_ContextCreated_ES(sender, e);
            else
            {
                // Here you can allocate resources or initialize state
                Gl.MatrixMode(MatrixMode.Projection);
                Gl.LoadIdentity();
                Gl.Ortho(0.0, 1.0f, 0.0, 1.0, 0.0, 1.0);

                // Uses multisampling, if available
                if (glControl.MultisampleBits > 0)
                    Gl.Enable(EnableCap.Multisample);
            }
        }

        private void RenderControl_Render(object sender, GlControlEventArgs e)
        {
            if (Gl.CurrentVersion.Api == KhronosVersion.ApiGles2)
                RenderControl_Render_ES(sender, e);
            else
                RenderControl_Render_GL(sender, e);
        }

        private void RenderControl_ContextDestroying(object sender, GlControlEventArgs e)
        {
            // Here you can dispose resources allocated in RenderControl_ContextCreated
            RenderControl_ContextDestroying_ES(sender, e);
        }

        private void Form_Resize(object sender, System.EventArgs e)
        {
            Size formSize = this.Size;
            formSize.Height -= 120;
            this.glControl1.Size = formSize;
        }

        #region Common Data

        private static float _Angle;

        /// <summary>
        /// Vertex position array.
        /// </summary>
        private static readonly float[] _ArrayPosition = new float[] {
            0.0f, 0.0f,
            0.5f, 1.0f,
            1.0f, 0.0f
        };

        /// <summary>
        /// Vertex color array.
        /// </summary>
        private static readonly float[] _ArrayColor = new float[] {
            1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f
        };

        #endregion

        #region GL Resources

        private void RenderControl_Render_GL(object sender, GlControlEventArgs e)
        {
            Control senderControl = (Control)sender;

            Gl.Viewport(0, 0, senderControl.ClientSize.Width, senderControl.ClientSize.Height);
            Gl.Clear(ClearBufferMask.ColorBufferBit);

            // Animate triangle
            Gl.MatrixMode(MatrixMode.Modelview);
            Gl.LoadIdentity();
            Gl.Rotate(_Angle, 0.0f, 0.0f, 1.0f);

            if (Gl.CurrentVersion >= Gl.Version_110)
            {
                // Old school OpenGL 1.1
                // Setup & enable client states to specify vertex arrays, and use Gl.DrawArrays instead of Gl.Begin/End paradigm
                using (MemoryLock vertexArrayLock = new MemoryLock(_ArrayPosition))
                using (MemoryLock vertexColorLock = new MemoryLock(_ArrayColor))
                {
                    // Note: the use of MemoryLock objects is necessary to pin vertex arrays since they can be reallocated by GC
                    // at any time between the Gl.VertexPointer execution and the Gl.DrawArrays execution

                    Gl.VertexPointer(2, VertexPointerType.Float, 0, vertexArrayLock.Address);
                    Gl.EnableClientState(EnableCap.VertexArray);

                    Gl.ColorPointer(3, ColorPointerType.Float, 0, vertexColorLock.Address);
                    Gl.EnableClientState(EnableCap.ColorArray);

                    Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
                }
            }
            else
            {
                // Old school OpenGL
                Gl.Begin(PrimitiveType.Triangles);
                Gl.Color3(1.0f, 0.0f, 0.0f); Gl.Vertex2(0.0f, 0.0f);
                Gl.Color3(0.0f, 1.0f, 0.0f); Gl.Vertex2(0.5f, 1.0f);
                Gl.Color3(0.0f, 0.0f, 1.0f); Gl.Vertex2(1.0f, 0.0f);
                Gl.End();
            }
        }

        #endregion

        #region ES Resources

        private void RenderControl_Render_ES(object sender, GlControlEventArgs e)
        {
            Control control = (Control)sender;
            OrthoProjectionMatrix projectionMatrix = new OrthoProjectionMatrix(0.0f, 1.0f, 0.0f, 1.0f, 0.0f, 1.0f);
            ModelMatrix modelMatrix = new ModelMatrix();

            // Animate triangle
            modelMatrix.RotateZ(_Angle);

            Gl.Viewport(0, 0, control.Width, control.Height);
            Gl.Clear(ClearBufferMask.ColorBufferBit);

            Gl.UseProgram(_Es2_Program);

            using (MemoryLock arrayPosition = new MemoryLock(_ArrayPosition))
            using (MemoryLock arrayColor = new MemoryLock(_ArrayColor))
            {
                Gl.VertexAttribPointer((uint)_Es2_Program_Location_aPosition, 2, Gl.FLOAT, false, 0, arrayPosition.Address);
                Gl.EnableVertexAttribArray((uint)_Es2_Program_Location_aPosition);

                Gl.VertexAttribPointer((uint)_Es2_Program_Location_aColor, 3, Gl.FLOAT, false, 0, arrayColor.Address);
                Gl.EnableVertexAttribArray((uint)_Es2_Program_Location_aColor);

                Gl.UniformMatrix4(_Es2_Program_Location_uMVP, 1, false, (projectionMatrix * modelMatrix).ToArray());

                Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
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
            _Es2_Program = Gl.CreateProgram();
            Gl.AttachShader(_Es2_Program, vertexShader);
            Gl.AttachShader(_Es2_Program, fragmentShader);
            Gl.LinkProgram(_Es2_Program);

            int linked;
            Gl.GetProgram(_Es2_Program, Gl.LINK_STATUS, out linked);

            if (linked == 0)
            {
                Gl.GetProgramInfoLog(_Es2_Program, 1024, out infologLength, infolog);
            }

            _Es2_Program_Location_uMVP = Gl.GetUniformLocation(_Es2_Program, "uMVP");
            _Es2_Program_Location_aPosition = Gl.GetAttribLocation(_Es2_Program, "aPosition");
            _Es2_Program_Location_aColor = Gl.GetAttribLocation(_Es2_Program, "aColor");
        }

        private void RenderControl_ContextDestroying_ES(object sender, OpenGL.GlControlEventArgs e)
        {
            if (_Es2_Program != 0)
                Gl.DeleteProgram(_Es2_Program);
            _Es2_Program = 0;
        }

        private uint _Es2_Program;

        private int _Es2_Program_Location_aPosition;

        private int _Es2_Program_Location_aColor;

        private int _Es2_Program_Location_uMVP;

        private readonly string[] _Es2_ShaderVertexSource = new string[] {
            "uniform mat4 uMVP;\n",
            "attribute vec2 aPosition;\n",
            "attribute vec3 aColor;\n",
            "varying vec3 vColor;\n",
            "void main() {\n",
            "	gl_Position = uMVP * vec4(aPosition, 0.0, 1.0);\n",
            "	vColor = aColor;\n",
            "}\n"
        };

        private readonly string[] _Es2_ShaderFragmentSource = new string[] {
            "precision mediump float;\n",
            "varying vec3 vColor;\n",
            "void main() {\n",
            "	gl_FragColor = vec4(vColor, 1.0);\n",
            "}\n"
        };

        #endregion

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Change triangle rotation
            _Angle = (_Angle + 0.5f) % 90.0f;

            // Issue a new frame after this render
            glControl1.Invalidate();
        }
    }
}
