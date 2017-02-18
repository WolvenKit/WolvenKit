using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;

using OpenGL;
using Assimp.Unmanaged;

namespace W3Edit.Render
{
    #region Structs
    [StructLayout(LayoutKind.Explicit)]
    struct Vertex3Float
    {
        [FieldOffset(0)]
        public float X;
        [FieldOffset(sizeof(float))]
        public float Y;
        [FieldOffset(sizeof(float)*2)]
        public float Z;
    }
    [StructLayout(LayoutKind.Explicit)]
    struct Vertex2Float
    {
        [FieldOffset(0)]
        public float X;
        [FieldOffset(sizeof(float))]
        public float Y;
    }
    [StructLayout(LayoutKind.Explicit)]
    struct Vertex
    {
        public static int getSizeOf()
        {
            return sizeof(float) * (2 * 3 + 2);
        }
        public static int getNormalOffset()
        {
            return sizeof(float) * 3;
        }
        public static int getTexCoordsOffset()
        {
            return sizeof(float) * 2 * 3;
        }
        // Position
        [FieldOffset(0)]
        public Vertex3Float Position;
        // Normal
        [FieldOffset(sizeof(float) * 3)]
        public Vertex3Float Normal;
        // TexCoords
        [FieldOffset(sizeof(float) * 2 * 3)]
        public Vertex2Float TexCoords;
    };

    struct Texture
    {
        public uint id;
        public string type;
        public AiString path;
    };
    #endregion

    class Mesh
    {
        #region Data
        /*  Render data  */
        public uint VAO, VBO, EBO;

        /*  Mesh Data  */
        public List<Vertex> vertices = new List<Vertex>();
        public List<uint> indices = new List<uint>();
        public List<Texture> textures = new List<Texture>();
        #endregion

        #region Functions
        // Constructor
        public Mesh(List<Vertex> vertices, List<uint> indices, List<Texture> textures)
        {
            this.vertices = vertices;
            this.indices  = indices;
            this.textures = textures;

            // Now that we have all the required data, set the vertex buffers and its attribute pointers.
            this.setupMesh();
        }

        // Render the mesh
        public void Draw(Shader shader)
        {
            // Bind appropriate textures
            uint diffuseNr = 1;
            uint specularNr = 1;
            for (int i = 0; i < this.textures.Count; i++)
            {
                Gl.ActiveTexture(Gl.TEXTURE0 + i); // Active proper texture unit before binding
                                                  // Retrieve texture number (the N in diffuse_textureN)
                StringBuilder stringBuilder = new StringBuilder();
                string number;
                string name = this.textures[i].type;
                if (name == "texture_diffuse")
                {
                    stringBuilder.Append(diffuseNr); // Transfer GLuint to stream
                    diffuseNr++;
                }
                else if (name == "texture_specular")
                {
                    stringBuilder.Append(specularNr); // Transfer GLuint to stream
                    specularNr++;
                }
                number = stringBuilder.ToString();
                // Now set the sampler to the correct texture unit
                Gl.Uniform1( Gl.GetUniformLocation(shader.Program, name + number), i );
                // And finally bind the texture
                Gl.BindTexture(TextureTarget.Texture2d, this.textures[i].id);
            }

            // Also set each mesh's shininess property to a default value (if you want you could extend this to another mesh property and possibly change this value)
            Gl.Uniform1(Gl.GetUniformLocation(shader.Program, "material.shininess"), 16.0f);

            // Draw mesh
            Gl.BindVertexArray(this.VAO);
            Gl.DrawElements(OpenGL.PrimitiveType.Triangles, this.indices.Count, DrawElementsType.UnsignedInt, (IntPtr)0);
            Gl.BindVertexArray(0);

            // Always good practice to set everything back to defaults once configured.
            for (int i = 0; i < this.textures.Count; i++)
            {
                Gl.ActiveTexture(Gl.TEXTURE0 + i);
                Gl.BindTexture(TextureTarget.Texture2d, 0);
            }
        }

        // Initializes all the buffer objects/arrays
        private void setupMesh()
        {
            using (MemoryLock verticesLock = new MemoryLock(this.vertices.ToArray()))
            using (MemoryLock indicesLock = new MemoryLock(this.indices.ToArray()))
            {
                // Create buffers/arrays
                this.VAO = Gl.GenVertexArray();
                this.VBO = Gl.GenBuffer();
                this.EBO = Gl.GenBuffer();

                Gl.BindVertexArray(this.VAO);
                // Load data into vertex buffers
                Gl.BindBuffer(BufferTargetARB.ArrayBuffer, this.VBO);
                // A great thing about structs is that their memory layout is sequential for all its items.
                // The effect is that we can simply pass a pointer to the struct and it translates perfectly to a glm::vec3/2 array which
                // again translates to 3/2 floats which translates to a byte array.
                // Marshal.SizeOf(typeof(Vertex))
                Gl.BufferData(BufferTargetARB.ArrayBuffer, (uint)(this.vertices.Count * Vertex.getSizeOf()), verticesLock.Address, BufferUsageARB.StaticDraw);

                Gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, this.EBO);
                Gl.BufferData(BufferTargetARB.ElementArrayBuffer, (uint)(this.indices.Count * sizeof(uint)), indicesLock.Address, BufferUsageARB.StaticDraw);

                // Set the vertex attribute pointers
                // Vertex Positions
                Gl.EnableVertexAttribArray(0);
                Gl.VertexAttribPointer(0, 3, Gl.FLOAT, false, Vertex.getSizeOf(), (IntPtr)0);
                // Vertex Normals
                Gl.EnableVertexAttribArray(1);
                Gl.VertexAttribPointer(1, 3, Gl.FLOAT, false, Vertex.getSizeOf(), (IntPtr)Vertex.getNormalOffset());
                // Vertex Texture Coords
                Gl.EnableVertexAttribArray(2);
                Gl.VertexAttribPointer(2, 2, Gl.FLOAT, false, Vertex.getSizeOf(), (IntPtr)Vertex.getTexCoordsOffset());

                Gl.BindVertexArray(0);
            }
        }
        #endregion
    }
}
