using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ElectricLight : Device
	{
		private CArray<CHandle<gameLightComponent>> _lightComponents;
		private CArray<gamedataLightPreset> _lightDefinitions;

		[Ordinal(87)] 
		[RED("lightComponents")] 
		public CArray<CHandle<gameLightComponent>> LightComponents
		{
			get => GetProperty(ref _lightComponents);
			set => SetProperty(ref _lightComponents, value);
		}

		[Ordinal(88)] 
		[RED("lightDefinitions")] 
		public CArray<gamedataLightPreset> LightDefinitions
		{
			get => GetProperty(ref _lightDefinitions);
			set => SetProperty(ref _lightDefinitions, value);
		}
	}
}
