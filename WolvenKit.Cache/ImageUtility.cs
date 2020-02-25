using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using W3Edit.Textures;

namespace WolvenKit.Cache
{
    public class ImageUtility
    {
        /// <summary>
        /// Convert a CBitmapTexture's image to a DDS image
        /// </summary>
        /// <returns>A proper dds file</returns>
        public static Bitmap Xbm2Dds(CR2WExportWrapper imagechunk)
        {
            try
            {
                var image = ((CBitmapTexture)(imagechunk.data)).Image;
                var compression = imagechunk.GetVariableByName("compression").ToString();
                var width = uint.Parse(imagechunk.GetVariableByName("width").ToString());
                var height = uint.Parse(imagechunk.GetVariableByName("height").ToString());
                var mips = imagechunk.GetVariableByName("residentMipIndex")!=null ? uint.Parse(imagechunk.GetVariableByName("residentMipIndex").ToString()) : 0;
                var tempfile = new MemoryStream();

                var dxt = DDSHeader.Format_DXT1;
                switch (compression)
                {
                    case "TCM_DXTNoAlpha":
                        dxt = DDSHeader.Format_DXT1;
                        break;
                    case "TCM_DXTAlpha":
                        dxt = DDSHeader.Format_DXT5;
                        break;
                    case "TCM_NormalsHigh":
                        dxt = DDSHeader.Format_DXT5;
                        break;
                    case "TCM_Normals":
                        dxt = DDSHeader.Format_DXT1;
                        break;
                    case "TCM_NormalsGloss":
                        dxt = DDSHeader.Format_DXT5;
                        break;
                    case "TCM_QualityControl":
                        dxt = DDSHeader.Format_DXT5;
                        break;
                    default:
                        throw new Exception("Invalid compression type! [" + compression + "]");
                }

                DDSHeader ddsheader = new DDSHeader();
                using (var bw = new BinaryWriter(tempfile))
                {
                    bw.Write(ddsheader.generate(width, height, mips, dxt).ToArray());
                    //bw.Write(image.Bytes);  // First 20 bytes is garbage
                    bw.Write( (new ArraySegment<byte>(image.Bytes, 20, image.Bytes.Length - 20)).ToArray() );
                }
                tempfile.Flush();
#if DEBUG
                //File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\asd.dds",tempfile.ToArray());
#endif
                return new DdsImage(tempfile.ToArray()).BitmapImage;
            }
            catch(Exception e)
            {
                string message = e.Message;
                string caption = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
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
