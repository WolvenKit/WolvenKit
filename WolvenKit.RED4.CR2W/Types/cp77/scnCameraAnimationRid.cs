using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCameraAnimationRid : CVariable
	{
		[Ordinal(0)] [RED("tag")] public scnRidTag Tag { get; set; }
		[Ordinal(1)] [RED("animation")] public CHandle<animIAnimationBuffer> Animation { get; set; }

		public scnCameraAnimationRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
