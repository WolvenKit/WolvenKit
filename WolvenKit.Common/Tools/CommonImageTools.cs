using ImageMagick;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Tools
{
    public static class CommonImageTools
    {

        public static void ConvertDDSTo(Stream stream)
        {
            using (var image = new MagickImage(stream))
            {
                



            }



        }

        public static void ReadImageMetaData(Stream stream)
        {
            var info = new MagickImageInfo(stream);

            stream.Seek(0, SeekOrigin.Begin);
            using (var image = new MagickImage(stream))
            {




            }

            

        }

        public static void ReadImageMetaData(string filepath)
        {
            var info = new MagickImageInfo(filepath);
            using (var image = new MagickImage(filepath))
            {




            }

            using (var image = Pfim.Pfim.FromFile(filepath))
            {


            }


            // expretimental wkit import
            //CommonImageTools.ReadImageMetaData(fullpath);

            // read metadata
            // width, height: can be gotten from ImageMagick
            // compression: look up in texturegroups.xml
            // texturegroup: gotten from here

            // unk1, unk2: ???
            // Mipdata: create mips?


            // create xbm

            // create cr2wfile
        }

    }
}
