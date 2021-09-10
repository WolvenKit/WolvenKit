using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ElectricLight : Device
	{
		[Ordinal(87)] 
		[RED("lightComponents")] 
		public CArray<CHandle<gameLightComponent>> LightComponents
		{
			get => GetPropertyValue<CArray<CHandle<gameLightComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameLightComponent>>>(value);
		}

		[Ordinal(88)] 
		[RED("lightDefinitions")] 
		public CArray<gamedataLightPreset> LightDefinitions
		{
			get => GetPropertyValue<CArray<gamedataLightPreset>>();
			set => SetPropertyValue<CArray<gamedataLightPreset>>(value);
		}

		public ElectricLight()
		{
			ControllerTypeName = "ElectricLightController";
			LightComponents = new();
			LightDefinitions = new();
		}
	}
}
