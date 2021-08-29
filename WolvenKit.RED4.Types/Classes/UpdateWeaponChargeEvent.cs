using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateWeaponChargeEvent : redEvent
	{
		private CFloat _newValue;
		private CFloat _oldValue;

		[Ordinal(0)] 
		[RED("newValue")] 
		public CFloat NewValue
		{
			get => GetProperty(ref _newValue);
			set => SetProperty(ref _newValue, value);
		}

		[Ordinal(1)] 
		[RED("oldValue")] 
		public CFloat OldValue
		{
			get => GetProperty(ref _oldValue);
			set => SetProperty(ref _oldValue, value);
		}
	}
}
