using System.Collections.Generic;
using System.Linq;
using Ab3d.DirectX.Materials;


namespace WolvenKit.Functionality.Ab4d
{
    public static class KnownTextureFiles
    {
        public struct KnownTextureFile
        {
            public TextureMapTypes TextureMapType;
            public List<string> FileSuffixes;

            public KnownTextureFile(TextureMapTypes textureMapType)
            {
                TextureMapType = textureMapType;
                FileSuffixes = new List<string>();
            }

            public KnownTextureFile(TextureMapTypes textureMapType, string fileSuffixes)
            {
                TextureMapType = textureMapType;
                FileSuffixes = fileSuffixes.Split(',').Select(f => f.Trim()).ToList();
            }
        }

        public static List<KnownTextureFile> TextureFiles;

        public static readonly TextureMapTypes[] PBRSupportedTextureMapTypes = new TextureMapTypes[]
        {
            TextureMapTypes.DiffuseColor, // DiffuseColor is used as BaseColor
            TextureMapTypes.BaseColor,
            TextureMapTypes.Metalness,
            TextureMapTypes.Roughness,
            TextureMapTypes.AmbientOcclusion,
            TextureMapTypes.NormalMap,
            TextureMapTypes.Emissive
        };

        static KnownTextureFiles()
        {
            // Based on https://help.sketchfab.com/hc/en-us/articles/202600873-Materials-and-Textures

            TextureFiles = new List<KnownTextureFile>
            {
                new KnownTextureFile(TextureMapTypes.DiffuseColor, "color, diffuse"),
                new KnownTextureFile(TextureMapTypes.Albedo, "albedo"),
                new KnownTextureFile(TextureMapTypes.BaseColor, "basecolor"),
                new KnownTextureFile(TextureMapTypes.Metalness, "metalness, metallic, metal, m"),
                new KnownTextureFile(TextureMapTypes.SpecularColor, "specular, spec, s"),
                new KnownTextureFile(TextureMapTypes.SpecularF0, "specularf0, f0"),
                new KnownTextureFile(TextureMapTypes.Roughness, "roughness, rough, r"),
                new KnownTextureFile(TextureMapTypes.MetalnessRoughness, "metalnessroughness"),
                new KnownTextureFile(TextureMapTypes.Glossiness, "glossiness, glossness, gloss, g, glossy"),
                new KnownTextureFile(TextureMapTypes.AmbientOcclusion, "ambientocclusion, ambient occlusion, ao, occlusion, lightmap, diffuseintensity"),
                new KnownTextureFile(TextureMapTypes.Cavity, "cavity"),
                new KnownTextureFile(TextureMapTypes.NormalMap, "normal, nrm, nmap, normalmap"),
                new KnownTextureFile(TextureMapTypes.Emissive, "emission, emit, emissive"),
                new KnownTextureFile(TextureMapTypes.Transparency, "transparency, transparent, opacity, mask, alpha"),
                new KnownTextureFile(TextureMapTypes.ReflectionMap, "reflection, reflect")
            };
        }



        // Returns TextureMapTypes from file name
        // File name must have any of the suffixes defined in the KnownTextureFiles.
        // The suffix must start with '-' or '_' and must be the last part of the file name before file extension.
        // Returns TextureMapTypes.Unknown when texture type cannot be determined
        public static TextureMapTypes GetTextureType(string fileName)
        {
            var rawFileName = System.IO.Path.GetFileNameWithoutExtension(fileName);

            if (string.IsNullOrEmpty(rawFileName))
            {
                return TextureMapTypes.Unknown;
            }

            var pos1 = rawFileName.LastIndexOf('_');
            var pos2 = rawFileName.LastIndexOf('-');

            if (pos2 > pos1)
            {
                pos1 = pos2;
            }

            if (pos1 == -1)
            {
                return TextureMapTypes.Unknown;
            }

            var fileSuffix = rawFileName.Substring(pos1 + 1).ToLower();

            for (var i = 0; i < TextureFiles.Count; i++)
            {
                if (TextureFiles[i].FileSuffixes.Contains(fileSuffix))
                {
                    return TextureFiles[i].TextureMapType;
                }
            }

            return TextureMapTypes.Unknown;
        }

        public static string GetFileNameWithoutKnownSuffix(string fileName)
        {
            var rawFileName = System.IO.Path.GetFileNameWithoutExtension(fileName);

            if (string.IsNullOrEmpty(rawFileName))
            {
                return rawFileName;
            }

            var pos1 = rawFileName.LastIndexOf('_');
            var pos2 = rawFileName.LastIndexOf('-');

            if (pos2 > pos1)
            {
                pos1 = pos2;
            }

            if (pos1 == -1)
            {
                return rawFileName;
            }

            return rawFileName.Substring(0, pos1);
        }
    }
}
