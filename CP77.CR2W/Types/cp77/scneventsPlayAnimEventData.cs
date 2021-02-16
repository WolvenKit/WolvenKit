using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayAnimEventData : CVariable
	{
		[Ordinal(0)] [RED("blendIn")] public CFloat BlendIn { get; set; }
		[Ordinal(1)] [RED("blendOut")] public CFloat BlendOut { get; set; }
		[Ordinal(2)] [RED("clipFront")] public CFloat ClipFront { get; set; }
		[Ordinal(3)] [RED("clipEnd")] public CFloat ClipEnd { get; set; }
		[Ordinal(4)] [RED("stretch")] public CFloat Stretch { get; set; }
		[Ordinal(5)] [RED("blendInCurve")] public CEnum<scnEasingType> BlendInCurve { get; set; }
		[Ordinal(6)] [RED("blendOutCurve")] public CEnum<scnEasingType> BlendOutCurve { get; set; }

		public scneventsPlayAnimEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
