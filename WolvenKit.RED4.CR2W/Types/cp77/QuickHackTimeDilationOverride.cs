using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackTimeDilationOverride : redEvent
	{
		private CBool _overrideDilationToTutorialPreset;

		[Ordinal(0)] 
		[RED("overrideDilationToTutorialPreset")] 
		public CBool OverrideDilationToTutorialPreset
		{
			get => GetProperty(ref _overrideDilationToTutorialPreset);
			set => SetProperty(ref _overrideDilationToTutorialPreset, value);
		}

		public QuickHackTimeDilationOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
