using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DestructibleMasterLight : DestructibleMasterDevice
	{
		[Ordinal(94)] 
		[RED("lightComponents")] 
		public CArray<CHandle<gameLightComponent>> LightComponents
		{
			get => GetPropertyValue<CArray<CHandle<gameLightComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameLightComponent>>>(value);
		}

		[Ordinal(95)] 
		[RED("lightDefinitions")] 
		public CArray<gamedataLightPreset> LightDefinitions
		{
			get => GetPropertyValue<CArray<gamedataLightPreset>>();
			set => SetPropertyValue<CArray<gamedataLightPreset>>(value);
		}

		public DestructibleMasterLight()
		{
			ControllerTypeName = "DestructibleMasterLightController";
			LightComponents = new();
			LightDefinitions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
