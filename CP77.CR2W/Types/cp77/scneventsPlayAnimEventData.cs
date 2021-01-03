using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayAnimEventData : CVariable
	{
		[Ordinal(0)]  [RED("blendIn")] public CFloat BlendIn { get; set; }
		[Ordinal(1)]  [RED("blendInCurve")] public CEnum<scnEasingType> BlendInCurve { get; set; }
		[Ordinal(2)]  [RED("blendOut")] public CFloat BlendOut { get; set; }
		[Ordinal(3)]  [RED("blendOutCurve")] public CEnum<scnEasingType> BlendOutCurve { get; set; }
		[Ordinal(4)]  [RED("clipEnd")] public CFloat ClipEnd { get; set; }
		[Ordinal(5)]  [RED("clipFront")] public CFloat ClipFront { get; set; }
		[Ordinal(6)]  [RED("stretch")] public CFloat Stretch { get; set; }

		public scneventsPlayAnimEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
