using System;
using System.IO;
using System.Linq;

namespace WolvenKit.Cache
{
    //TEXTURE.CACHE HCXT + INT32(VERSION?) AT THE END
    //SOUNDPC.CACHE CS3W AT THE START
    //STATICSHADER.CACHE,SHADER.CACHE  RDHS + INT32(VERSION?) AT THE END
    //COLLISION.CACHE CC3W AT THE START
    //FURSHADER.CACHE?
    public class Cache
    {
        #region Fields

        public static byte[] CollisionIdString = { (byte)'C', (byte)'C', (byte)'3', (byte)'W' };
        public static byte[] DepIdString = { (byte)'S', (byte)'P', (byte)'E', (byte)'D' };
        public static byte[] ShaderIdString = { (byte)'R', (byte)'D', (byte)'H', (byte)'S' };
        public static byte[] SoundIdString = { (byte)'C', (byte)'S', (byte)'3', (byte)'W' };
        public static byte[] TextureIdString = { (byte)'H', (byte)'C', (byte)'X', (byte)'T' };

        #endregion Fields

        #region Enums

        public enum Cachetype
        {
            Texture,
            Sound,
            Shader,
            Collision,
            Dep,
            Unknown
        }

        #endregion Enums

        #region Methods

        public static Cachetype GetCacheTypeOfFile(string path)
        {
            using (var br = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                try
                {
                    var idString = br.ReadBytes(4);
                    br.BaseStream.Seek(-8, SeekOrigin.End);
                    var idStringBack = br.ReadBytes(4);
                    if (idStringBack.SequenceEqual(TextureIdString))
                        return Cachetype.Texture;
                    if (idString.SequenceEqual(SoundIdString))
                        return Cachetype.Sound;
                    if (idString.SequenceEqual(DepIdString))
                        return Cachetype.Dep;
                    if (idString.SequenceEqual(CollisionIdString))
                        return Cachetype.Collision;
                    return idStringBack.SequenceEqual(ShaderIdString) ? Cachetype.Shader : Cachetype.Unknown;
                }
                catch (Exception)
                {
                    return Cachetype.Unknown;
                }
            }
        }

        #endregion Methods
    }
}
