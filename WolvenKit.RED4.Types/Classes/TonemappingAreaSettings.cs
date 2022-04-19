using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TonemappingAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("mode")] 
		public CHandle<ITonemappingMode> Mode
		{
			get => GetPropertyValue<CHandle<ITonemappingMode>>();
			set => SetPropertyValue<CHandle<ITonemappingMode>>(value);
		}

		[Ordinal(3)] 
		[RED("hdrMode")] 
		public CHandle<ITonemappingMode> HdrMode
		{
			get => GetPropertyValue<CHandle<ITonemappingMode>>();
			set => SetPropertyValue<CHandle<ITonemappingMode>>(value);
		}

		public TonemappingAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
