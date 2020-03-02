using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Cache
{
    using DDS;
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

                var format = ETextureFormat.TEXFMT_R8G8B8A8;
                switch (compression)
                {
                    case "TCM_DXTNoAlpha":
                        format = ETextureFormat.TEXFMT_BC1;
                        break;
                    case "TCM_DXTAlpha":
                        format = ETextureFormat.TEXFMT_BC3;
                        break;
                    case "TCM_NormalsHigh":
                        format = ETextureFormat.TEXFMT_BC3;
                        break;
                    case "TCM_Normals":
                        format = ETextureFormat.TEXFMT_BC1;
                        break;
                    case "TCM_NormalsGloss":
                        format = ETextureFormat.TEXFMT_BC3;
                        break;
                    case "TCM_QualityControl":
                        format = ETextureFormat.TEXFMT_BC3;
                        break;
                    default:
                        throw new Exception("Invalid compression type! [" + compression + "]");
                }

                
                using (var bw = new BinaryWriter(tempfile))
                {
                    var metadata = new DDSMetadata(width, height, mips, format);
                    DDSUtils.GenerateAndWriteHeader(bw.BaseStream, metadata);

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
