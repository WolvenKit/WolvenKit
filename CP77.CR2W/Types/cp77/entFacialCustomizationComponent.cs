using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entFacialCustomizationComponent : entIComponent
	{
		[Ordinal(0)]  [RED("customizationSet")] public raRef<animFacialCustomizationSet> CustomizationSet { get; set; }
		[Ordinal(1)]  [RED("debugIgnoreComponent")] public CBool DebugIgnoreComponent { get; set; }
		[Ordinal(2)]  [RED("ears")] public CUInt32 Ears { get; set; }
		[Ordinal(3)]  [RED("eyes")] public CUInt32 Eyes { get; set; }
		[Ordinal(4)]  [RED("jaw")] public CUInt32 Jaw { get; set; }
		[Ordinal(5)]  [RED("mouth")] public CUInt32 Mouth { get; set; }
		[Ordinal(6)]  [RED("nose")] public CUInt32 Nose { get; set; }

		public entFacialCustomizationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
