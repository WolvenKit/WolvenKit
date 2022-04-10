using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questHUDEntryAnimationFinished : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hudEntry")] 
		public CName HudEntry
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("finished")] 
		public CBool Finished
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questHUDEntryAnimationFinished()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
