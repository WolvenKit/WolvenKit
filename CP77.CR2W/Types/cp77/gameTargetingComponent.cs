using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTargetingComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("isPrimary")] public CBool IsPrimary { get; set; }
		[Ordinal(1)]  [RED("isDirectional")] public CBool IsDirectional { get; set; }
		[Ordinal(2)]  [RED("aimAssistData")] public CArray<TweakDBID> AimAssistData { get; set; }
		[Ordinal(3)]  [RED("alwaysInTestRange")] public CBool AlwaysInTestRange { get; set; }

		public gameTargetingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
