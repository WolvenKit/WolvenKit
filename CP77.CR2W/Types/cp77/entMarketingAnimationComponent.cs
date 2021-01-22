using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entMarketingAnimationComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("animations")] public CArray<entMarketingAnimationEntry> Animations { get; set; }
		[Ordinal(1)]  [RED("enableLookAt")] public CBool EnableLookAt { get; set; }
		[Ordinal(2)]  [RED("freezeAnimations")] public CBool FreezeAnimations { get; set; }
		[Ordinal(3)]  [RED("lookAtOrbitDistance")] public CFloat LookAtOrbitDistance { get; set; }
		[Ordinal(4)]  [RED("lookAtSettings")] public CHandle<animLookAtPreset_FullControl> LookAtSettings { get; set; }
		[Ordinal(5)]  [RED("lookAtTargetPitch")] public CFloat LookAtTargetPitch { get; set; }
		[Ordinal(6)]  [RED("lookAtTargetYaw")] public CFloat LookAtTargetYaw { get; set; }

		public entMarketingAnimationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
