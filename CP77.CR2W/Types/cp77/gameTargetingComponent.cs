using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTargetingComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("aimAssistData")] public CArray<TweakDBID> AimAssistData { get; set; }
		[Ordinal(1)]  [RED("alwaysInTestRange")] public CBool AlwaysInTestRange { get; set; }
		[Ordinal(2)]  [RED("isDirectional")] public CBool IsDirectional { get; set; }
		[Ordinal(3)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(4)]  [RED("isPrimary")] public CBool IsPrimary { get; set; }

		public gameTargetingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
