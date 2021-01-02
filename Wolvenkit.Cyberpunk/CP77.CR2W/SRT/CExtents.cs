using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.SRT
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CExtents
    {
        public float[] m_cExtents { get; set; } = new float[6];

        public void Write(BinaryWriter bw)
        {
            for (int i = 0; i < 6; i++)
            {
                bw.Write(m_cExtents[i]);
            }
        }
    }
}
