using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTargetingComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("isPrimary")] public CBool IsPrimary { get; set; }
		[Ordinal(6)] [RED("isDirectional")] public CBool IsDirectional { get; set; }
		[Ordinal(7)] [RED("aimAssistData")] public CArray<TweakDBID> AimAssistData { get; set; }
		[Ordinal(8)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(9)] [RED("alwaysInTestRange")] public CBool AlwaysInTestRange { get; set; }

		public gameTargetingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
