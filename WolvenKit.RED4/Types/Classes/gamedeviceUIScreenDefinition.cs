using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedeviceUIScreenDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("screenType")] 
		public TweakDBID ScreenType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gamedeviceUIScreenDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
