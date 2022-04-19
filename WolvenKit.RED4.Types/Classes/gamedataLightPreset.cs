using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataLightPreset : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lightSourcesName")] 
		public CName LightSourcesName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("preset")] 
		public TweakDBID Preset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gamedataLightPreset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
