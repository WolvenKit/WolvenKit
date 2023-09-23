using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElectricLight : Device
	{
		[Ordinal(88)] 
		[RED("lightComponents")] 
		public CArray<CHandle<gameLightComponent>> LightComponents
		{
			get => GetPropertyValue<CArray<CHandle<gameLightComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameLightComponent>>>(value);
		}

		[Ordinal(89)] 
		[RED("lightDefinitions")] 
		public CArray<gamedataLightPreset> LightDefinitions
		{
			get => GetPropertyValue<CArray<gamedataLightPreset>>();
			set => SetPropertyValue<CArray<gamedataLightPreset>>(value);
		}

		public ElectricLight()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
