using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Assimp;
using OpenGL;
using System.IO;

namespace WolvenKit.Render
{
    class Model
    {
        #region Model Data
        public List<Mesh> meshes = new List<Mesh>();
        private string directory;
        public List<Texture> textures_loaded = new List<Texture>();    // Stores all the textures loaded so far, optimization to make sure textures aren't loaded more than once.
        #endregion

        #region Functions
        // Constructor, expects a filepath to a 3D model.
        public Model(string path)
        {
            this.loadModel(path);
        }

        // Draws the model, and thus all its meshes
        public void Draw(Shader shader)
        {
            for (int i = 0; i < this.meshes.Count; i++)
                this.meshes[i].Draw(shader);
        }

        // Loads a model with supported ASSIMP extensions from file and stores the resulting meshes in the meshes vector.
        private void loadModel(string path)
        {
            try
            {
                // Read file via ASSIMP
                Assimp.AssimpContext importer = new Assimp.AssimpContext();
                Scene scene = importer.ImportFile(path, PostProcessSteps.Triangulate | PostProcessSteps.FlipUVs);
                // Check for errors
                /*if (scene.SceneFlags == SceneFlags.Incomplete || Node.Equals(scene.RootNode, 0)) // if is Not Zero
                {
                    Console.WriteLine("ERROR::ASSIMP::");
                    return;
                }*/
                // Retrieve the directory path of the filepath
                this.directory = path.Substring(0, path.LastIndexOf('/'));

                // Process ASSIMP's root node recursively
                this.processNode(scene.RootNode, scene);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.bithack3D, ex.ToString());
                Program.bithack3D.BeginInvoke(new MethodInvoker(Program.bithack3D.Close));
            }
        }

        // Processes a node in a recursive fashion. Processes each individual mesh located at the node and repeats this process on its children nodes (if any).
        private void processNode(Assimp.Node node, Assimp.Scene scene)
        {
            // Process each mesh located at the current node
            for (int i = 0; i < node.MeshCount; i++)
            {
                // The node object only contains indices to index the actual objects in the scene. 
                // The scene contains all the data, node is just to keep stuff organized (like relations between nodes).
                Assimp.Mesh mesh = scene.Meshes[node.MeshIndices[i]];
                this.meshes.Add(this.processMesh(mesh, scene));
            }
            // After we've processed all of the meshes (if any) we then recursively process each of the children nodes
            for (int i = 0; i < node.ChildCount; i++)
            {
                this.processNode(node.Children[i], scene);
            }
        }

        private Mesh processMesh(Assimp.Mesh mesh, Assimp.Scene scene)
        {
            // Data to fill
            List<Vertex> vertices = new List<Vertex>();
            List<uint> indices = new List<uint>();
            List<Texture> textures = new List<Texture>();

            // Walk through each of the mesh's vertices
            for (int i = 0; i < mesh.VertexCount; i++)
            {
                Vertex vertex = new Vertex();
                //Vertex3 vector = new Vertex3();
                // We declare a placeholder vector since assimp uses its own vector class that doesn't directly convert to glm's vec3 class so we transfer the data to this placeholder glm::vec3 first.
                // Positions
                vertex.Position.X = mesh.Vertices[i].X;
                vertex.Position.Y = mesh.Vertices[i].Y;
                vertex.Position.Z = mesh.Vertices[i].Z;
                //vertex.Position = vector;
                // Normals
                if (mesh.HasNormals)
                {
                    vertex.Normal.X = mesh.Normals[i].X;
                    vertex.Normal.Y = mesh.Normals[i].Y;
                    vertex.Normal.Z = mesh.Normals[i].Z;
                }
                //vertex.Normal = vector;
                // Texture Coordinates
                if (mesh.HasTextureCoords(0)) // Does the mesh contain texture coordinates?
                {
                    Vertex2f vec;
                    // A vertex can contain up to 8 different texture coordinates. We thus make the assumption that we won't 
                    // use models where a vertex can have multiple texture coordinates so we always take the first set (0).
                    vec.x = mesh.TextureCoordinateChannels[0][i].X;
                    vec.y = mesh.TextureCoordinateChannels[0][i].Y;
                    vertex.TexCoords.X = vec.X;
                    vertex.TexCoords.Y = vec.Y;
                }
                else
                    vertex.TexCoords.X = vertex.TexCoords.Y = 0;
                vertices.Add(vertex);
            }
            // Now wak through each of the mesh's faces (a face is a mesh its triangle) and retrieve the corresponding vertex indices.
            for (int i = 0; i < mesh.FaceCount; i++)
            {
                Assimp.Face face = mesh.Faces[i];
                // Retrieve all indices of the face and store them in the indices vector
                for (int j = 0; j < face.IndexCount; j++)
                    indices.Add((uint)face.Indices[j]);
            }
            // Process materials
            if (mesh.MaterialIndex >= 0)
            {
                Assimp.Material material = scene.Materials[mesh.MaterialIndex];
                // We assume a convention for sampler names in the shaders. Each diffuse texture should be named
                // as 'texture_diffuseN' where N is a sequential number ranging from 1 to MAX_SAMPLER_NUMBER. 
                // Same applies to other texture as the following list summarizes:
                // Diffuse: texture_diffuseN
                // Specular: texture_specularN
                // Normal: texture_normalN

                // 1. Diffuse maps
                List<Texture> diffuseMaps = this.loadMaterialTextures(material, TextureType.Diffuse, "texture_diffuse");
                textures.InsertRange(textures.Count, diffuseMaps);
                // 2. Specular maps
                List<Texture> specularMaps = this.loadMaterialTextures(material, TextureType.Specular, "texture_specular");
                textures.InsertRange(textures.Count, specularMaps);
            }

            // Return a mesh object created from the extracted mesh data
            return new Mesh(vertices, indices, textures);
        }

        // Checks all material textures of a given type and loads the textures if they're not loaded yet.
        // The required info is returned as a Texture struct.
        private List<Texture> loadMaterialTextures(Material mat, TextureType type, string typeName)
        {
            List<Texture> textures = new List<Texture>();
            for (int i = 0; i < mat.GetMaterialTextureCount(type); i++)
            {
                TextureSlot str;
                mat.GetMaterialTexture(type, i, out str);
                // Check if texture was loaded before and if so, continue to next iteration: skip loading a new texture
                bool skip = false;
                for (int j = 0; j < textures_loaded.Count; j++)
                {
                    if (textures_loaded[j].path.Equals(new Assimp.Unmanaged.AiString(str.FilePath)))
                    {
                        textures.Add(textures_loaded[j]);
                        skip = true; // A texture with the same filepath has already been loaded, continue to next one. (optimization)
                        break;
                    }
                }
                if (!skip)
                {   // If texture hasn't been loaded already, load it
                    Texture texture;
                    texture.id = TextureFromFile(str.FilePath, this.directory);
                    texture.type = typeName;
                    texture.path = new Assimp.Unmanaged.AiString(str.FilePath);
                    textures.Add(texture);
                    this.textures_loaded.Add(texture);  // Store it as texture loaded for entire model, to ensure we won't unnecesery load duplicate textures.
                }
            }
            return textures;
        }

        private uint TextureFromFile(string filename, string directory)
        {
            //Generate texture ID and load texture data 
            filename = directory + '/' + filename;
            uint textureID = Gl.GenTexture();

            Bitmap bitmap = LoadImage(filename);
            System.Drawing.Imaging.BitmapData imageData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // Assign texture to ID
            Gl.BindTexture(TextureTarget.Texture2d, textureID);
            Gl.TexImage2D(TextureTarget.Texture2d, 0, Gl.RGB, bitmap.Width, bitmap.Height, 0, PixelFormat.Bgr, PixelType.UnsignedByte, imageData.Scan0);
            Gl.GenerateMipmap(Gl.TEXTURE_2D);

            // Parameters
            Gl.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, Gl.REPEAT);
            Gl.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, Gl.REPEAT);
            Gl.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, Gl.LINEAR_MIPMAP_LINEAR);
            Gl.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, Gl.LINEAR);
            Gl.BindTexture(TextureTarget.Texture2d, 0);

            bitmap.Dispose();
            return textureID;
        }

        private Bitmap LoadImage(string filename)
        {
            switch(Path.GetExtension(filename))
            {
                case ".tga":
                    return TargaImage.LoadTargaImage(filename);
                default:
                    return new Bitmap(filename);
            }
        }
        #endregion
    }
}
