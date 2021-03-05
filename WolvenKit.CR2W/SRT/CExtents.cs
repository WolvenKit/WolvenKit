using System.ComponentModel;
using System.IO;

namespace WolvenKit.CR2W.SRT
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CExtents
    {
        #region Properties

        public float[] m_cExtents { get; set; } = new float[6];

        #endregion Properties

        #region Methods

        public void Write(BinaryWriter bw)
        {
            for (int i = 0; i < 6; i++)
            {
                bw.Write(m_cExtents[i]);
            }
        }

        #endregion Methods
    }
}
