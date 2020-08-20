using System;
using System.IO;

namespace WolvenKit
{
    /// <summary>
    /// Class responsible for importing and exporting .dds images in and out of CSwfTexture variable
    /// Probably could be better :P But works.
    /// </summary>
    class DDSUtility
    {
        #region DDS Structs
        // Structs to define the header of a dds image file

        public struct DDSHeader
        {
            public uint size;
            public uint flags;
            public uint width;
            public uint height;
            public uint sizeorpitch;
            public uint depth;
            public uint mipmapcount;
            public uint alphabitdepth;
            public uint[] reserved;

            public DDSPixelFormat pixelformat;
            public DDSCaps ddscaps;

            public uint texturestage;
        }

        public struct DDSPixelFormat
        {
            public uint size;
            public uint flags;
            public uint fourcc;
            public uint rgbbitcount;
            public uint rbitmask;
            public uint gbitmask;
            public uint bbitmask;
            public uint alphabitmask;
        }

        public struct DDSCaps
        {
            public uint caps1;
            public uint caps2;
            public uint caps3;
            public uint caps4;
        }
        #endregion
        
        #region CSwfTexture Struct
        //The embedded image file inside the CSwfTexture var
        //has some small header which is just 7 Uint32 vars
        //After that is just the image contents.

        struct CSwfTextureHeader
        {
            public uint Unknown1;   //No idea - Always seems to be 0. Normally where the byte length is stored in other vars.
            public uint Unknown2;   //Could be image depth? - Will stay an unknown for now
            public uint Width;      //Image Width
            public uint Height;     //Image Height
            public uint Unknown5;   //No idea
            public uint PixelCount; //Total Pixels
            public uint Unknown7;   //No idea
        }
        #endregion
        
        /// <summary>
        /// This method converts a byte array from the CR2W to a dds format byte array
        /// This should only be used when exporting from a CSwfTexture var (swfTexture).
        /// </summary>
        /// <param name="bytes">Byte array to export from the CR2W file</param>
        /// <returns>The bytes to export</returns>
        public static byte[] ExportAsDDS( byte[] bytes )
        {
            var mem = new MemoryStream(bytes);
            var reader = new BinaryReader(mem);
            var header = new DDSHeader();

            //Values from the CR2W file
            var unk1            = reader.ReadUInt32();
            var unk2            = reader.ReadUInt32();
            header.width        = reader.ReadUInt32();
            header.height       = reader.ReadUInt32();
            var unk5            = reader.ReadUInt32();
            header.sizeorpitch  = reader.ReadUInt32();
            var unk7            = reader.ReadUInt32();

            //Hard Coded values
            //No idea how to get these values from the CR2W file
            //However they seem to be the same for all images from
            //uncooking the game.
            //No issues with the exported images when using these values.
            header.size                 = Convert.ToUInt32(124);            //Always needs to be 124 - standard dds headers are 128 excluding this.
            header.flags                = Convert.ToUInt32(659463);
            header.depth                = Convert.ToUInt32(1);
            header.mipmapcount          = Convert.ToUInt32(1);
            header.pixelformat.size     = Convert.ToUInt32(32);
            header.pixelformat.flags    = Convert.ToUInt32(4);
            header.pixelformat.fourcc   = Convert.ToUInt32(894720068);
            header.ddscaps.caps1        = Convert.ToUInt32(4096);

            header.reserved = new uint[10];

            byte[] headerBytes = ConstructDDSHeader(header);

            var memout = new MemoryStream();
            var writer = new BinaryWriter(memout);

            writer.Write(headerBytes);
            var left = Convert.ToInt32(reader.BaseStream.Length - reader.BaseStream.Position);
            writer.Write(reader.ReadBytes(left));

            return memout.ToArray();
        }

        /// <summary>
        /// This method takes a dds file, as a binary reader, and converts
        /// it into a compatible byte array for importing in a CSwfTexture var
        /// </summary>
        /// <param name="file">Binary reader of the dds file</param>
        /// <returns>A byte array of the converted image</returns>
        public static byte[] ImportFromDDS( BinaryReader file )
        {
            var header = ReadDDSHeader(file);

            var memout = new MemoryStream();
            var writer = new BinaryWriter(memout);

            //Unknown 1
            writer.Write(Convert.ToUInt32(0));
            //Unknown 2
            writer.Write(Convert.ToUInt32(1));
            //Width
            writer.Write(header.width);
            //Height
            writer.Write(header.height);
            //Unknown 5
            writer.Write(Convert.ToUInt32(0));
            //Pixel Count
            writer.Write(header.sizeorpitch);
            //Unknown 7
            writer.Write(Convert.ToUInt32(16));

            var left = Convert.ToInt32(file.BaseStream.Length - file.BaseStream.Position);
            writer.Write(file.ReadBytes(left));

            return memout.ToArray();
        }

        /// <ConstructDDSHeader>
        /// This takes a DDSHeader and constructs the byte
        /// array for a dds image file from it.
        /// </summary>
        /// <param name="header">The header object</param>
        /// <returns>Byte array of the header</returns>
        static byte[] ConstructDDSHeader(DDSHeader header)
        {
            var memout = new MemoryStream();
            var writer = new BinaryWriter(memout);

            writer.Write(Convert.ToByte('D'));
            writer.Write(Convert.ToByte('D'));
            writer.Write(Convert.ToByte('S'));
            writer.Write(Convert.ToByte(' '));

            writer.Write(header.size);
            writer.Write(header.flags);
            writer.Write(header.height);
            writer.Write(header.width);
            writer.Write(header.sizeorpitch);
            writer.Write(header.depth);
            writer.Write(header.mipmapcount);
            writer.Write(header.alphabitdepth);

            for (int i = 0; i < 10; i++)
            {
                writer.Write(header.reserved[i]);
            }

            writer.Write(header.pixelformat.size);
            writer.Write(header.pixelformat.flags);
            writer.Write(header.pixelformat.fourcc);
            writer.Write(header.pixelformat.rgbbitcount);
            writer.Write(header.pixelformat.rbitmask);
            writer.Write(header.pixelformat.gbitmask);
            writer.Write(header.pixelformat.bbitmask);
            writer.Write(header.pixelformat.alphabitmask);

            writer.Write(header.ddscaps.caps1);
            writer.Write(header.ddscaps.caps2);
            writer.Write(header.ddscaps.caps3);
            writer.Write(header.ddscaps.caps4);

            writer.Write(header.texturestage);

            return memout.ToArray();
        }

        /// <summary>
        /// This reads the binary stream from the import file and 
        /// creates the DDSHeader object from it.
        /// </summary>
        /// <param name="reader">The import file</param>
        /// <returns>A DDSHeader object</returns>
        static DDSHeader ReadDDSHeader( BinaryReader reader )
        {
            byte[] signature = reader.ReadBytes(4);
            if (!(signature[0] == 'D' 
               && signature[1] == 'D' 
               && signature[2] == 'S'
               && signature[3] == ' '))
            {
                throw new Exception( "Invalid File Type" );
            }

            var header = new DDSHeader();

            header.size = reader.ReadUInt32();
            if (header.size != 124)
            {
                throw new Exception("Invalid File Type");
            }

            header.flags = reader.ReadUInt32();
            header.height = reader.ReadUInt32();
            header.width = reader.ReadUInt32();
            header.sizeorpitch = reader.ReadUInt32();
            header.depth = reader.ReadUInt32();
            header.mipmapcount = reader.ReadUInt32();
            header.alphabitdepth = reader.ReadUInt32();

            header.reserved = new uint[10];
            for (int i = 0; i < 10; i++)
            {
                header.reserved[i] = reader.ReadUInt32();
            }

            header.pixelformat.size = reader.ReadUInt32();
            header.pixelformat.flags = reader.ReadUInt32();
            header.pixelformat.fourcc = reader.ReadUInt32();
            header.pixelformat.rgbbitcount = reader.ReadUInt32();
            header.pixelformat.rbitmask = reader.ReadUInt32();
            header.pixelformat.gbitmask = reader.ReadUInt32();
            header.pixelformat.bbitmask = reader.ReadUInt32();
            header.pixelformat.alphabitmask = reader.ReadUInt32();

            header.ddscaps.caps1 = reader.ReadUInt32();
            header.ddscaps.caps2 = reader.ReadUInt32();
            header.ddscaps.caps3 = reader.ReadUInt32();
            header.ddscaps.caps4 = reader.ReadUInt32();
            header.texturestage = reader.ReadUInt32();

            return header;
        }

        /* - Method used when testing
        static void PrintHeader( DDSHeader header )
        {
            Console.WriteLine("header.");
            Console.WriteLine("\tsize             {0}", header.size);
            Console.WriteLine("\tflags            {0}", header.flags);
            Console.WriteLine("\twidth            {0}", header.width);
            Console.WriteLine("\theight           {0}", header.height);
            Console.WriteLine("\tsizeorpitch      {0}", header.sizeorpitch);
            Console.WriteLine("\tdepth            {0}", header.depth);
            Console.WriteLine("\tmipmapcount      {0}", header.mipmapcount);
            Console.WriteLine("\talphabitdepth    {0}", header.alphabitdepth);
            for (int i = 0; i < header.reserved.Length; i++)
            {
                Console.WriteLine("\treserved[{0}]      {1}", i, header.reserved[i]);
            }
            Console.WriteLine("header.pixelformat");
            Console.WriteLine("\tsize             {0}", header.pixelformat.size);
            Console.WriteLine("\tflags            {0}", header.pixelformat.flags);
            Console.WriteLine("\tfourcc           {0}", header.pixelformat.fourcc);
            Console.WriteLine("\trgbbitcount      {0}", header.pixelformat.rgbbitcount);
            Console.WriteLine("\trbitmask         {0}", header.pixelformat.rbitmask);
            Console.WriteLine("\tgbitmask         {0}", header.pixelformat.gbitmask);
            Console.WriteLine("\tbbitmask         {0}", header.pixelformat.bbitmask);
            Console.WriteLine("\talphabitmask     {0}", header.pixelformat.alphabitmask);
            Console.WriteLine("header.ddscaps");
            Console.WriteLine("\tcaps1            {0}", header.ddscaps.caps1);
            Console.WriteLine("\tcaps2            {0}", header.ddscaps.caps2);
            Console.WriteLine("\tcaps3            {0}", header.ddscaps.caps3);
            Console.WriteLine("\tcaps4            {0}", header.ddscaps.caps4);
        }
        */
    }
}