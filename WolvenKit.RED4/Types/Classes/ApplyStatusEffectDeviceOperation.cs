using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyStatusEffectDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("statusEffects")] 
		public CArray<SStatusEffectOperationData> StatusEffects
		{
			get => GetPropertyValue<CArray<SStatusEffectOperationData>>();
			set => SetPropertyValue<CArray<SStatusEffectOperationData>>(value);
		}

		public ApplyStatusEffectDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();
			StatusEffects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
