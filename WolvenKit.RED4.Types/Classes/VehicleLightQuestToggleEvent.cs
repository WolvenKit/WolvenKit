using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleLightQuestToggleEvent : redEvent
	{
		private CBool _toggle;
		private CEnum<vehicleELightType> _lightType;

		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetProperty(ref _toggle);
			set => SetProperty(ref _toggle, value);
		}

		[Ordinal(1)] 
		[RED("lightType")] 
		public CEnum<vehicleELightType> LightType
		{
			get => GetProperty(ref _lightType);
			set => SetProperty(ref _lightType, value);
		}

		public VehicleLightQuestToggleEvent()
		{
			_lightType = new() { Value = Enums.vehicleELightType.Default };
		}
	}
}
