using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
    [REDMeta]
    public class CAreaComponent : CBoundedComponent
    {
        [RED("height")] public CFloat Height { get; set; }

        [RED("color")] public CColor Color { get; set; }

        [RED("terrainSide")] public EAreaTerrainSide TerrainSide { get; set; }

        [RED("clippingMode")] public EAreaClippingMode ClippingMode { get; set; }

        [RED("clippingAreaTags")] public TagList ClippingAreaTags { get; set; }

        [RED("saveShapeToLayer")] public CBool SaveShapeToLayer { get; set; }

        [RED("localPoints", 2, 0)] public CArray<Vector> LocalPoints { get; set; }

        [RED("worldPoints", 2, 0)] public CArray<Vector> WorldPoints { get; set; }


        [REDBuffer] public CByteArray2 bufferdata { get; set; }

        public CAreaComponent(CR2WFile cr2w) :
            base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CAreaComponent(cr2w);
        }
    }
}