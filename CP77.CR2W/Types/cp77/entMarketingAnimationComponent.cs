using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entMarketingAnimationComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("freezeAnimations")] public CBool FreezeAnimations { get; set; }
		[Ordinal(6)] [RED("animations")] public CArray<entMarketingAnimationEntry> Animations { get; set; }
		[Ordinal(7)] [RED("enableLookAt")] public CBool EnableLookAt { get; set; }
		[Ordinal(8)] [RED("lookAtSettings")] public CHandle<animLookAtPreset_FullControl> LookAtSettings { get; set; }
		[Ordinal(9)] [RED("lookAtOrbitDistance")] public CFloat LookAtOrbitDistance { get; set; }
		[Ordinal(10)] [RED("lookAtTargetPitch")] public CFloat LookAtTargetPitch { get; set; }
		[Ordinal(11)] [RED("lookAtTargetYaw")] public CFloat LookAtTargetYaw { get; set; }

		public entMarketingAnimationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
