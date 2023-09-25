using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApartmentScreenControllerPS : LcdScreenControllerPS
	{
		[Ordinal(111)] 
		[RED("initialRentStatus")] 
		public CEnum<ERentStatus> InitialRentStatus
		{
			get => GetPropertyValue<CEnum<ERentStatus>>();
			set => SetPropertyValue<CEnum<ERentStatus>>(value);
		}

		[Ordinal(112)] 
		[RED("overdueMessageRecordID")] 
		public TweakDBID OverdueMessageRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(113)] 
		[RED("paidMessageRecordID")] 
		public TweakDBID PaidMessageRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(114)] 
		[RED("evictionMessageRecordID")] 
		public TweakDBID EvictionMessageRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(115)] 
		[RED("paymentSchedule")] 
		public CEnum<EPaymentSchedule> PaymentSchedule
		{
			get => GetPropertyValue<CEnum<EPaymentSchedule>>();
			set => SetPropertyValue<CEnum<EPaymentSchedule>>(value);
		}

		[Ordinal(116)] 
		[RED("showOverdueValue")] 
		public CBool ShowOverdueValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("randomizeInitialOverdue")] 
		public CBool RandomizeInitialOverdue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(118)] 
		[RED("initialOverdue")] 
		public CInt32 InitialOverdue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(119)] 
		[RED("allowAutomaticRentStatusChange")] 
		public CBool AllowAutomaticRentStatusChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(120)] 
		[RED("maxDays")] 
		public CInt32 MaxDays
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(121)] 
		[RED("currentOverdue")] 
		public CInt32 CurrentOverdue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(122)] 
		[RED("isInitialRentStateSet")] 
		public CBool IsInitialRentStateSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(123)] 
		[RED("currentRentStatus")] 
		public CEnum<ERentStatus> CurrentRentStatus
		{
			get => GetPropertyValue<CEnum<ERentStatus>>();
			set => SetPropertyValue<CEnum<ERentStatus>>(value);
		}

		[Ordinal(124)] 
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
