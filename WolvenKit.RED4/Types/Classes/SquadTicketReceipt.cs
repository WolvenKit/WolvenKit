using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SquadTicketReceipt : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("acknowledgedTimeStamp")] 
		public CFloat AcknowledgedTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("conditionDeactivationCheckTimeStamp")] 
		public CFloat ConditionDeactivationCheckTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("conditionDeactivationSuccessfulCheckTimeStamp")] 
		public CFloat ConditionDeactivationSuccessfulCheckTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("conditionCheckRandomizedInterval")] 
		public CFloat ConditionCheckRandomizedInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("lastRecipient")] 
		public entEntityID LastRecipient
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(5)] 
		[RED("acknowledgesInQueue")] 
		public CInt32 AcknowledgesInQueue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("numberOfOrders")] 
		public CInt32 NumberOfOrders
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("cooldownID")] 
		public CInt32 CooldownID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SquadTicketReceipt()
		{
			LastRecipient = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
