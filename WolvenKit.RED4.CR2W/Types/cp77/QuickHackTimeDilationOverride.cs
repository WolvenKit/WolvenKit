using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackTimeDilationOverride : redEvent
	{
		[Ordinal(0)] [RED("overrideDilationToTutorialPreset")] public CBool OverrideDilationToTutorialPreset { get; set; }

		public QuickHackTimeDilationOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
