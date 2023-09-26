using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocMeterCapacityApplyEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("CurrentCapacity")] 
		public CInt32 CurrentCapacity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("MaxCapacity")] 
		public CInt32 MaxCapacity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("OverchargeCapacity")] 
		public CInt32 OverchargeCapacity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("MaxCapacityPossible")] 
		public CFloat MaxCapacityPossible
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("IsPurchase")] 
		public CBool IsPurchase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RipperdocMeterCapacityApplyEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
