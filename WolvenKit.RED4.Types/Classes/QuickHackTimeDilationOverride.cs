using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickHackTimeDilationOverride : redEvent
	{
		private CBool _overrideDilationToTutorialPreset;

		[Ordinal(0)] 
		[RED("overrideDilationToTutorialPreset")] 
		public CBool OverrideDilationToTutorialPreset
		{
			get => GetProperty(ref _overrideDilationToTutorialPreset);
			set => SetProperty(ref _overrideDilationToTutorialPreset, value);
		}
	}
}
