using System;
using System.Collections.Generic;
using System.Text;

namespace Convert
{
    public class WEM
    {
        public FileRead _fr;
        public uint _id = 0;
        public uint _offset = 0;
        public uint _size = 0;
        public string _data = "";

        public WEM(FileRead fr = null)
        {
            if(fr != null)
            {
                _id = fr.read_uint32();
                _offset = fr.read_uint32();
                _size = fr.read_uint32();
            }
        }
    }
}
