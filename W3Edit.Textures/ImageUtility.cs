using System;
using System.Drawing;
using System.IO;
using System.Linq;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Cache
{
    public class ImageUtility
    {
        /// <summary>
        /// Convert a CBitmapTexture's image to a DDS image
        /// </summary>
        /// <returns>A proper dds file</returns>
        public static Bitmap Xbm2Dds(CR2WChunk imagechunk)
        {
            try
            {
                var image = ((CBitmapTexture)(imagechunk.data)).Image;
                var compression = imagechunk.GetVariableByName("compression").ToString();
                var width = int.Parse(imagechunk.GetVariableByName("width").ToString());
                var height = int.Parse(imagechunk.GetVariableByName("height").ToString());
                var mips = imagechunk.GetVariableByName("residentMipIndex")!=null ? int.Parse(imagechunk.GetVariableByName("residentMipIndex").ToString()) : 0;
                var tempfile = new MemoryStream();
                /* DDS magic header contains:
                 *      Required .dds flags for compressed texture without pitch
                 * More on: https://msdn.microsoft.com/en-us/library/windows/desktop/bb943982(v=vs.85).aspx */
                /*byte[] ddsheader = 
                {
                    0x44, 0x44, 0x53, 0x20, 0x7C, 0x00, 0x00, 0x00, 0x07, 0x10, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00,
                    0x05, 0x00, 0x00, 0x00, 0x44, 0x58, 0x54, 0x31, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x10, 0x40, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                };*/
                uint dxt;
                switch (compression)
                {
                    case "TCM_DXTNoAlpha":
                        dxt = Textures.DDSHeader.Format_DXT5;
                        break;
                    case "TCM_DXTAlpha":
                        dxt = Textures.DDSHeader.Format_DXT5;
                        break;
                    /*case "TCM_NormalsHigh":
                        dxt = Textures.DDSHeader.Format_DXT5;
                        break;
                    case "TCM_Normals":
                        dxt = Textures.DDSHeader.Format_DXT5;
                        break;*/
                    default:
                        throw new Exception("Invalid compression type! [" + compression + "]");
                }
                /*using (var bw = new BinaryWriter(tempfile))
                {
                    bw.Write(ddsheader);
                    bw.Seek(0xC, SeekOrigin.Begin);
                    bw.Write(height);
                    bw.Seek(0x10, SeekOrigin.Begin);
                    bw.Write(width);
                    bw.Seek(0x54, SeekOrigin.Begin);
                    bw.Write(dxt);
                    bw.Seek(128, SeekOrigin.Begin);
                    bw.Write(image.Bytes);
                }*/
                Textures.DDSHeader ddsheader = new Textures.DDSHeader();
                using (var bw = new BinaryWriter(tempfile))
                {
                    bw.Write(ddsheader.generate((uint)width, (uint)height, (uint)mips, dxt).ToArray());
                    //bw.Write(image.Bytes);
                    bw.Write( (new ArraySegment<byte>(image.Bytes, 20, image.Bytes.Length - 20)).ToArray() );
                }
                tempfile.Flush();
#if DEBUG
                File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\asd.dds",tempfile.GetBuffer());
#endif
                return new DdsImage(tempfile.GetBuffer()).BitmapImage;
            }
            catch(Exception)
            {
                // fails silently...
                return null;
            }
            
        }

        /// <summary>
        /// Convert a DDS image to a CBitmapTexture style image
        /// </summary>
        /// <param name="ddsImage">The buffer to remove the header from</param>
        /// <returns>CBitmapTexture style image</returns>
        public static byte[] Dds2Xbm(byte[] ddsImage)
        {
            return ddsImage.Length > 128 ? ddsImage.Skip(128).ToArray() : new byte[0];
        }
    }
}
