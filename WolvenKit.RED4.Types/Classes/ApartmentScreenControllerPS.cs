using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApartmentScreenControllerPS : LcdScreenControllerPS
	{
		private CEnum<ERentStatus> _initialRentStatus;
		private TweakDBID _overdueMessageRecordID;
		private TweakDBID _paidMessageRecordID;
		private TweakDBID _evictionMessageRecordID;
		private CEnum<EPaymentSchedule> _paymentSchedule;
		private CBool _randomizeInitialOverdue;
		private CInt32 _initialOverdue;
		private CBool _allowAutomaticRentStatusChange;
		private CInt32 _maxDays;
		private CInt32 _currentOverdue;
		private CBool _isInitialRentStateSet;
		private CEnum<ERentStatus> _currentRentStatus;
		private CInt32 _lastStatusChangeDay;

		[Ordinal(108)] 
		[RED("initialRentStatus")] 
		public CEnum<ERentStatus> InitialRentStatus
		{
			get => GetProperty(ref _initialRentStatus);
			set => SetProperty(ref _initialRentStatus, value);
		}

		[Ordinal(109)] 
		[RED("overdueMessageRecordID")] 
		public TweakDBID OverdueMessageRecordID
		{
			get => GetProperty(ref _overdueMessageRecordID);
			set => SetProperty(ref _overdueMessageRecordID, value);
		}

		[Ordinal(110)] 
		[RED("paidMessageRecordID")] 
		public TweakDBID PaidMessageRecordID
		{
			get => GetProperty(ref _paidMessageRecordID);
			set => SetProperty(ref _paidMessageRecordID, value);
		}

		[Ordinal(111)] 
		[RED("evictionMessageRecordID")] 
		public TweakDBID EvictionMessageRecordID
		{
			get => GetProperty(ref _evictionMessageRecordID);
			set => SetProperty(ref _evictionMessageRecordID, value);
		}

		[Ordinal(112)] 
		[RED("paymentSchedule")] 
		public CEnum<EPaymentSchedule> PaymentSchedule
		{
			get => GetProperty(ref _paymentSchedule);
			set => SetProperty(ref _paymentSchedule, value);
		}

		[Ordinal(113)] 
		[RED("randomizeInitialOverdue")] 
		public CBool RandomizeInitialOverdue
		{
			get => GetProperty(ref _randomizeInitialOverdue);
			set => SetProperty(ref _randomizeInitialOverdue, value);
		}

		[Ordinal(114)] 
		[RED("initialOverdue")] 
		public CInt32 InitialOverdue
		{
			get => GetProperty(ref _initialOverdue);
			set => SetProperty(ref _initialOverdue, value);
		}

		[Ordinal(115)] 
		[RED("allowAutomaticRentStatusChange")] 
		public CBool AllowAutomaticRentStatusChange
		{
			get => GetProperty(ref _allowAutomaticRentStatusChange);
			set => SetProperty(ref _allowAutomaticRentStatusChange, value);
		}

		[Ordinal(116)] 
		[RED("maxDays")] 
		public CInt32 MaxDays
		{
			get => GetProperty(ref _maxDays);
			set => SetProperty(ref _maxDays, value);
		}

		[Ordinal(117)] 
		[RED("currentOverdue")] 
		public CInt32 CurrentOverdue
		{
			get => GetProperty(ref _currentOverdue);
			set => SetProperty(ref _currentOverdue, value);
		}

		[Ordinal(118)] 
		[RED("isInitialRentStateSet")] 
		public CBool IsInitialRentStateSet
		{
			get => GetProperty(ref _isInitialRentStateSet);
			set => SetProperty(ref _isInitialRentStateSet, value);
		}

		[Ordinal(119)] 
		[RED("currentRentStatus")] 
		public CEnum<ERentStatus> CurrentRentStatus
		{
			get => GetProperty(ref _currentRentStatus);
			set => SetProperty(ref _currentRentStatus, value);
		}

		[Ordinal(120)] 
		[RED("lastStatusChangeDay")] 
		public CInt32 LastStatusChangeDay
		{
			get => GetProperty(ref _lastStatusChangeDay);
			set => SetProperty(ref _lastStatusChangeDay, value);
		}

		public ApartmentScreenControllerPS()
		{
			_randomizeInitialOverdue = true;
			_allowAutomaticRentStatusChange = true;
			_maxDays = 90;
		}
	}
}
