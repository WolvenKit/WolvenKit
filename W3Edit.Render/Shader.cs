using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

using OpenGL;

namespace W3Edit.Render
{
    class Shader
    {
        public uint Program;
        public int uLocation_Projection;
        public int uLocation_View;
        public int uLocation_Model;
        // Constructor generates the shader from source
        public Shader(string[] vertexSource, string[] fragmentSource)
        {
            CompileShaders(string.Join("", vertexSource), string.Join("", fragmentSource));
        }
        // Constructor generates the shader on the fly
        public Shader(string vertexPath, string fragmentPath)
        {
            // 1. Retrieve the vertex/fragment source code from filePath
            string vertexCode = "";
            string fragmentCode = "";
            // ensures ifstream objects can throw exceptions:
            try
            {
                // Open files
                using (FileStream vShaderFile = new FileStream(vertexPath, FileMode.Open))
                using (FileStream fShaderFile = new FileStream(fragmentPath, FileMode.Open))
                using (StreamReader vShaderStream = new StreamReader(vShaderFile))
                using (StreamReader fShaderStream = new StreamReader(fShaderFile))
                {
                    // Read file's buffer contents into streams
                    vertexCode = vShaderStream.ReadToEnd();
                    fragmentCode = fShaderStream.ReadToEnd();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(new Form { TopMost = true }, "ERROR::SHADER::FILE_NOT_SUCCESFULLY_READ");
                Environment.Exit(1);
            }
            // 2. Compile shaders
            CompileShaders(vertexCode, fragmentCode);
        }

        private void CompileShaders(string vertexCode, string fragmentCode)
        {
            uint vertex, fragment;
            int success;
            StringBuilder infoLog = new StringBuilder(512);
            // Vertex Shader
            vertex = Gl.CreateShader(Gl.VERTEX_SHADER);
            Gl.ShaderSource(vertex, new[] { vertexCode });
            Gl.CompileShader(vertex);
            // Print compile errors if any
            Gl.GetShader(vertex, Gl.COMPILE_STATUS, out success);
            if (success == 0)
            {
                int length;
                Gl.GetShaderInfoLog(vertex, 512, out length, infoLog);
                MessageBox.Show(new Form { TopMost = true }, "ERROR::SHADER::VERTEX::COMPILATION_FAILED\n" + infoLog.ToString());
                Environment.Exit(1);
            }
            // Fragment Shader
            fragment = Gl.CreateShader(Gl.FRAGMENT_SHADER);
            Gl.ShaderSource(fragment, new[] { fragmentCode });
            Gl.CompileShader(fragment);
            // Print compile errors if any
            Gl.GetShader(fragment, Gl.COMPILE_STATUS, out success);
            if (success == 0)
            {
                int length;
                Gl.GetShaderInfoLog(vertex, 512, out length, infoLog);
                MessageBox.Show(new Form { TopMost = true }, "ERROR::SHADER::FRAGMENT::COMPILATION_FAILED\n" + infoLog.ToString());
                Environment.Exit(1);
            }
            // Shader Program
            this.Program = Gl.CreateProgram();
            Gl.AttachShader(this.Program, vertex);
            Gl.AttachShader(this.Program, fragment);
            Gl.LinkProgram(this.Program);
            // Print linking errors if any
            Gl.GetProgram(this.Program, Gl.LINK_STATUS, out success);
            if (success == 0)
            {
                int length;
                Gl.GetProgramInfoLog(this.Program, 512, out length, infoLog);
                MessageBox.Show(new Form { TopMost = true }, "ERROR::SHADER::PROGRAM::LINKING_FAILED\n" + infoLog.ToString());
                Environment.Exit(1);
            }
            // Delete the shaders as they're linked into our program now and no longer necessery
            Gl.DeleteShader(vertex);
            Gl.DeleteShader(fragment);
        }

        // Uses the current shader
        public void Use()
        {
            Gl.UseProgram(this.Program);
        }
    }
}
