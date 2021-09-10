using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestructibleMasterLight : DestructibleMasterDevice
	{
		[Ordinal(97)] 
		[RED("lightComponents")] 
		public CArray<CHandle<gameLightComponent>> LightComponents
		{
			get => GetPropertyValue<CArray<CHandle<gameLightComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameLightComponent>>>(value);
		}

		[Ordinal(98)] 
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
		}
	}
}
