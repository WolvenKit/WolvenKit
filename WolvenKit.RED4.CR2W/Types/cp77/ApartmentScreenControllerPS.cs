using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApartmentScreenControllerPS : LcdScreenControllerPS
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

		[Ordinal(107)] 
		[RED("initialRentStatus")] 
		public CEnum<ERentStatus> InitialRentStatus
		{
			get
			{
				if (_initialRentStatus == null)
				{
					_initialRentStatus = (CEnum<ERentStatus>) CR2WTypeManager.Create("ERentStatus", "initialRentStatus", cr2w, this);
				}
				return _initialRentStatus;
			}
			set
			{
				if (_initialRentStatus == value)
				{
					return;
				}
				_initialRentStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("overdueMessageRecordID")] 
		public TweakDBID OverdueMessageRecordID
		{
			get
			{
				if (_overdueMessageRecordID == null)
				{
					_overdueMessageRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "overdueMessageRecordID", cr2w, this);
				}
				return _overdueMessageRecordID;
			}
			set
			{
				if (_overdueMessageRecordID == value)
				{
					return;
				}
				_overdueMessageRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("paidMessageRecordID")] 
		public TweakDBID PaidMessageRecordID
		{
			get
			{
				if (_paidMessageRecordID == null)
				{
					_paidMessageRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "paidMessageRecordID", cr2w, this);
				}
				return _paidMessageRecordID;
			}
			set
			{
				if (_paidMessageRecordID == value)
				{
					return;
				}
				_paidMessageRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("evictionMessageRecordID")] 
		public TweakDBID EvictionMessageRecordID
		{
			get
			{
				if (_evictionMessageRecordID == null)
				{
					_evictionMessageRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "evictionMessageRecordID", cr2w, this);
				}
				return _evictionMessageRecordID;
			}
			set
			{
				if (_evictionMessageRecordID == value)
				{
					return;
				}
				_evictionMessageRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("paymentSchedule")] 
		public CEnum<EPaymentSchedule> PaymentSchedule
		{
			get
			{
				if (_paymentSchedule == null)
				{
					_paymentSchedule = (CEnum<EPaymentSchedule>) CR2WTypeManager.Create("EPaymentSchedule", "paymentSchedule", cr2w, this);
				}
				return _paymentSchedule;
			}
			set
			{
				if (_paymentSchedule == value)
				{
					return;
				}
				_paymentSchedule = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("randomizeInitialOverdue")] 
		public CBool RandomizeInitialOverdue
		{
			get
			{
				if (_randomizeInitialOverdue == null)
				{
					_randomizeInitialOverdue = (CBool) CR2WTypeManager.Create("Bool", "randomizeInitialOverdue", cr2w, this);
				}
				return _randomizeInitialOverdue;
			}
			set
			{
				if (_randomizeInitialOverdue == value)
				{
					return;
				}
				_randomizeInitialOverdue = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("initialOverdue")] 
		public CInt32 InitialOverdue
		{
			get
			{
				if (_initialOverdue == null)
				{
					_initialOverdue = (CInt32) CR2WTypeManager.Create("Int32", "initialOverdue", cr2w, this);
				}
				return _initialOverdue;
			}
			set
			{
				if (_initialOverdue == value)
				{
					return;
				}
				_initialOverdue = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("allowAutomaticRentStatusChange")] 
		public CBool AllowAutomaticRentStatusChange
		{
			get
			{
				if (_allowAutomaticRentStatusChange == null)
				{
					_allowAutomaticRentStatusChange = (CBool) CR2WTypeManager.Create("Bool", "allowAutomaticRentStatusChange", cr2w, this);
				}
				return _allowAutomaticRentStatusChange;
			}
			set
			{
				if (_allowAutomaticRentStatusChange == value)
				{
					return;
				}
				_allowAutomaticRentStatusChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("maxDays")] 
		public CInt32 MaxDays
		{
			get
			{
				if (_maxDays == null)
				{
					_maxDays = (CInt32) CR2WTypeManager.Create("Int32", "maxDays", cr2w, this);
				}
				return _maxDays;
			}
			set
			{
				if (_maxDays == value)
				{
					return;
				}
				_maxDays = value;
				PropertySet(this);
			}
		}

		[Ordinal(116)] 
		[RED("currentOverdue")] 
		public CInt32 CurrentOverdue
		{
			get
			{
				if (_currentOverdue == null)
				{
					_currentOverdue = (CInt32) CR2WTypeManager.Create("Int32", "currentOverdue", cr2w, this);
				}
				return _currentOverdue;
			}
			set
			{
				if (_currentOverdue == value)
				{
					return;
				}
				_currentOverdue = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("isInitialRentStateSet")] 
		public CBool IsInitialRentStateSet
		{
			get
			{
				if (_isInitialRentStateSet == null)
				{
					_isInitialRentStateSet = (CBool) CR2WTypeManager.Create("Bool", "isInitialRentStateSet", cr2w, this);
				}
				return _isInitialRentStateSet;
			}
			set
			{
				if (_isInitialRentStateSet == value)
				{
					return;
				}
				_isInitialRentStateSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("currentRentStatus")] 
		public CEnum<ERentStatus> CurrentRentStatus
		{
			get
			{
				if (_currentRentStatus == null)
				{
					_currentRentStatus = (CEnum<ERentStatus>) CR2WTypeManager.Create("ERentStatus", "currentRentStatus", cr2w, this);
				}
				return _currentRentStatus;
			}
			set
			{
				if (_currentRentStatus == value)
				{
					return;
				}
				_currentRentStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("lastStatusChangeDay")] 
		public CInt32 LastStatusChangeDay
		{
			get
			{
				if (_lastStatusChangeDay == null)
				{
					_lastStatusChangeDay = (CInt32) CR2WTypeManager.Create("Int32", "lastStatusChangeDay", cr2w, this);
				}
				return _lastStatusChangeDay;
			}
			set
			{
				if (_lastStatusChangeDay == value)
				{
					return;
				}
				_lastStatusChangeDay = value;
				PropertySet(this);
			}
		}

		public ApartmentScreenControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
