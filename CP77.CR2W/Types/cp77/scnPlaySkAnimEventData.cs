using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimEventData : CVariable
	{
		[Ordinal(0)]  [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(1)]  [RED("blendIn")] public CFloat BlendIn { get; set; }
		[Ordinal(2)]  [RED("blendOut")] public CFloat BlendOut { get; set; }
		[Ordinal(3)]  [RED("bodyPartMask")] public CName BodyPartMask { get; set; }
		[Ordinal(4)]  [RED("clipFront")] public CFloat ClipFront { get; set; }
		[Ordinal(5)]  [RED("stretch")] public CFloat Stretch { get; set; }
		[Ordinal(6)]  [RED("weight")] public CFloat Weight { get; set; }

		public scnPlaySkAnimEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
