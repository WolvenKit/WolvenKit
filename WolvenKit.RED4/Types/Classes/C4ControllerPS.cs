using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class C4ControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(120)] 
		[RED("itemTweakDBString")] 
		public CName ItemTweakDBString
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public C4ControllerPS()
		{
			IsScanned = true;
			ExposeQuickHacks = true;
			TweakDBRecord = 44966449988;
			TweakDBDescriptionRecord = 97999174197;
			ItemTweakDBString = "C4";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
