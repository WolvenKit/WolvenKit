using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateWeaponChargeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newValue")] 
		public CFloat NewValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("oldValue")] 
		public CFloat OldValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public UpdateWeaponChargeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
