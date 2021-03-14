using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SquadTicketReceipt : CVariable
	{
		private CFloat _acknowledgedTimeStamp;
		private CFloat _conditionDeactivationCheckTimeStamp;
		private CFloat _conditionDeactivationSuccessfulCheckTimeStamp;
		private CFloat _conditionCheckRandomizedInterval;
		private entEntityID _lastRecipient;
		private CInt32 _acknowledgesInQueue;
		private CInt32 _numberOfOrders;
		private CInt32 _cooldownID;

		[Ordinal(0)] 
		[RED("acknowledgedTimeStamp")] 
		public CFloat AcknowledgedTimeStamp
		{
			get
			{
				if (_acknowledgedTimeStamp == null)
				{
					_acknowledgedTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "acknowledgedTimeStamp", cr2w, this);
				}
				return _acknowledgedTimeStamp;
			}
			set
			{
				if (_acknowledgedTimeStamp == value)
				{
					return;
				}
				_acknowledgedTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("conditionDeactivationCheckTimeStamp")] 
		public CFloat ConditionDeactivationCheckTimeStamp
		{
			get
			{
				if (_conditionDeactivationCheckTimeStamp == null)
				{
					_conditionDeactivationCheckTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "conditionDeactivationCheckTimeStamp", cr2w, this);
				}
				return _conditionDeactivationCheckTimeStamp;
			}
			set
			{
				if (_conditionDeactivationCheckTimeStamp == value)
				{
					return;
				}
				_conditionDeactivationCheckTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("conditionDeactivationSuccessfulCheckTimeStamp")] 
		public CFloat ConditionDeactivationSuccessfulCheckTimeStamp
		{
			get
			{
				if (_conditionDeactivationSuccessfulCheckTimeStamp == null)
				{
					_conditionDeactivationSuccessfulCheckTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "conditionDeactivationSuccessfulCheckTimeStamp", cr2w, this);
				}
				return _conditionDeactivationSuccessfulCheckTimeStamp;
			}
			set
			{
				if (_conditionDeactivationSuccessfulCheckTimeStamp == value)
				{
					return;
				}
				_conditionDeactivationSuccessfulCheckTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("conditionCheckRandomizedInterval")] 
		public CFloat ConditionCheckRandomizedInterval
		{
			get
			{
				if (_conditionCheckRandomizedInterval == null)
				{
					_conditionCheckRandomizedInterval = (CFloat) CR2WTypeManager.Create("Float", "conditionCheckRandomizedInterval", cr2w, this);
				}
				return _conditionCheckRandomizedInterval;
			}
			set
			{
				if (_conditionCheckRandomizedInterval == value)
				{
					return;
				}
				_conditionCheckRandomizedInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lastRecipient")] 
		public entEntityID LastRecipient
		{
			get
			{
				if (_lastRecipient == null)
				{
					_lastRecipient = (entEntityID) CR2WTypeManager.Create("entEntityID", "lastRecipient", cr2w, this);
				}
				return _lastRecipient;
			}
			set
			{
				if (_lastRecipient == value)
				{
					return;
				}
				_lastRecipient = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("acknowledgesInQueue")] 
		public CInt32 AcknowledgesInQueue
		{
			get
			{
				if (_acknowledgesInQueue == null)
				{
					_acknowledgesInQueue = (CInt32) CR2WTypeManager.Create("Int32", "acknowledgesInQueue", cr2w, this);
				}
				return _acknowledgesInQueue;
			}
			set
			{
				if (_acknowledgesInQueue == value)
				{
					return;
				}
				_acknowledgesInQueue = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("numberOfOrders")] 
		public CInt32 NumberOfOrders
		{
			get
			{
				if (_numberOfOrders == null)
				{
					_numberOfOrders = (CInt32) CR2WTypeManager.Create("Int32", "numberOfOrders", cr2w, this);
				}
				return _numberOfOrders;
			}
			set
			{
				if (_numberOfOrders == value)
				{
					return;
				}
				_numberOfOrders = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cooldownID")] 
		public CInt32 CooldownID
		{
			get
			{
				if (_cooldownID == null)
				{
					_cooldownID = (CInt32) CR2WTypeManager.Create("Int32", "cooldownID", cr2w, this);
				}
				return _cooldownID;
			}
			set
			{
				if (_cooldownID == value)
				{
					return;
				}
				_cooldownID = value;
				PropertySet(this);
			}
		}

		public SquadTicketReceipt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
