using System.ComponentModel;

namespace WolvenKit.CR2W.SRT
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SLodProfile
    {
        #region Properties

        public bool m_bLodIsPresent { get; set; }

        public float m_f3dRange { get; set; }

        public float m_fBillboardFinalDistance { get; set; }

        public float m_fBillboardRange { get; set; }

        // m_fLowDetail3dDistance - m_fHighDetail3dDistance
        public float m_fBillboardStartDistance { get; set; }

        // pack four st_float32 values together for optimal 4fv shader upload
        public float m_fHighDetail3dDistance { get; set; } // distance at which LOD transition from highest 3D level begins

                                                           // distance at which the billboard begins to fade in and 3D fade out
                                                           // m_fBillboardFinalDistance - m_fBillboardStartDistance

        public float m_fLowDetail3dDistance { get; set; }

        #endregion Properties

        // distance at which the lowest 3D level is sustained
        // distance at which the billboard is fully visible and 3D is completely gone
    }
}
