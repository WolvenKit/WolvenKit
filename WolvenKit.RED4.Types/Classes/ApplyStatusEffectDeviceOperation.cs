using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyStatusEffectDeviceOperation : DeviceOperationBase
	{
		private CArray<SStatusEffectOperationData> _statusEffects;

		[Ordinal(5)] 
		[RED("statusEffects")] 
		public CArray<SStatusEffectOperationData> StatusEffects
		{
			get => GetProperty(ref _statusEffects);
			set => SetProperty(ref _statusEffects, value);
		}
	}
}
