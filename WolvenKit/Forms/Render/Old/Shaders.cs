namespace WolvenKit.Render
{
    class Shaders
    {
        #region Default Shaders
        public static readonly string[] _Es2_ShaderVertexSource = new string[] {
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
        public static readonly string[] _Es2_ShaderFragmentSource = new string[] {
            "varying vec3 vColor;\n",
            "void main() {\n",
            "	gl_FragColor = vec4(vColor, 1.0);\n",
            "}\n"
        };
        #endregion

        #region Model Shaders
        public static class Model
        {
            public static readonly string uLocation_Projection = "projection";
            public static readonly string uLocation_View = "view";
            public static readonly string uLocation_Model = "model";
            public static readonly string[] VertexSource = new string[] {
                "#version 330 core\n",
                "layout(location = 0) in vec3 position;\n",
                "layout(location = 1) in vec3 normal;\n",
                "layout(location = 2) in vec2 texCoords;\n",

                "out vec2 TexCoords;\n",

                "uniform mat4 projection;\n",
                "uniform mat4 view;\n",
                "uniform mat4 model;\n",

                "void main()\n",
                "{\n",
                    "gl_Position = projection * view * model * vec4(position, 1.0f);\n",
                    "TexCoords = texCoords;\n",
                "}\n"
            };
            public static readonly string[] FragmentSource = new string[] {
                "#version 330 core\n",

                "in vec2 TexCoords;\n",

                "out vec4 color;\n",

                "uniform sampler2D texture_diffuse1;\n",

                "void main()\n",
                "{\n",
                    "color = vec4(texture(texture_diffuse1, TexCoords));\n",
                "}\n"
            };
        }
        #endregion
    }
}
