using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Wwise.WEM
{
    class Packet
    {
        UInt16 size = 0;
        UInt32 offset = 0;
        UInt32 absolute_granule = 0;
        bool no_granule;

        public Packet(BinaryReader wem, UInt32 off, bool nogranule)
        {
            offset = off;
            absolute_granule = 0;
            no_granule = nogranule;
            size = wem.ReadUInt16();

            if (!no_granule)
                absolute_granule = wem.ReadUInt32();
        }

        public UInt16 Len => size;

        public UInt32 get_header_size()
        {
            return no_granule ? (uint)2 : (uint)6;

        }

        public UInt32 get_offset()
        {
            return offset + get_header_size();
        }

        public UInt32 get_next_offset()
        {
            return get_offset() + size;
        }
    }
}
