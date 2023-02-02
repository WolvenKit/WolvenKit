using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickHackTimeDilationOverride : redEvent
	{
		[Ordinal(0)] 
		[RED("overrideDilationToTutorialPreset")] 
		public CBool OverrideDilationToTutorialPreset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickHackTimeDilationOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
