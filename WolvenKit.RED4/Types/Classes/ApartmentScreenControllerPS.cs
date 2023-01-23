using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApartmentScreenControllerPS : LcdScreenControllerPS
	{
		[Ordinal(108)] 
		[RED("initialRentStatus")] 
		public CEnum<ERentStatus> InitialRentStatus
		{
			get => GetPropertyValue<CEnum<ERentStatus>>();
			set => SetPropertyValue<CEnum<ERentStatus>>(value);
		}

		[Ordinal(109)] 
		[RED("overdueMessageRecordID")] 
		public TweakDBID OverdueMessageRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(110)] 
		[RED("paidMessageRecordID")] 
		public TweakDBID PaidMessageRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(111)] 
		[RED("evictionMessageRecordID")] 
		public TweakDBID EvictionMessageRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(112)] 
		[RED("paymentSchedule")] 
		public CEnum<EPaymentSchedule> PaymentSchedule
		{
			get => GetPropertyValue<CEnum<EPaymentSchedule>>();
			set => SetPropertyValue<CEnum<EPaymentSchedule>>(value);
		}

		[Ordinal(113)] 
		[RED("showOverdueValue")] 
		public CBool ShowOverdueValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(114)] 
		[RED("randomizeInitialOverdue")] 
		public CBool RandomizeInitialOverdue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(115)] 
		[RED("initialOverdue")] 
		public CInt32 InitialOverdue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(116)] 
		[RED("allowAutomaticRentStatusChange")] 
		public CBool AllowAutomaticRentStatusChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("maxDays")] 
		public CInt32 MaxDays
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(118)] 
		[RED("currentOverdue")] 
		public CInt32 CurrentOverdue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(119)] 
		[RED("isInitialRentStateSet")] 
		public CBool IsInitialRentStateSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(120)] 
		[RED("currentRentStatus")] 
		public CEnum<ERentStatus> CurrentRentStatus
		{
			get => GetPropertyValue<CEnum<ERentStatus>>();
			set => SetPropertyValue<CEnum<ERentStatus>>(value);
		}

		[Ordinal(121)] 
		[RED("lastStatusChangeDay")] 
		public CInt32 LastStatusChangeDay
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ApartmentScreenControllerPS()
		{
			ShowOverdueValue = true;
			RandomizeInitialOverdue = true;
			AllowAutomaticRentStatusChange = true;
			MaxDays = 90;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
