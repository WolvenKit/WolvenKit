using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OperationExecutionData : IScriptable
	{
		private CName _operationName;
		private CFloat _delay;
		private CBool _resetDelay;
		private gameDelayID _delayID;
		private CBool _isDelayActive;

		[Ordinal(0)] 
		[RED("operationName")] 
		public CName OperationName
		{
			get
			{
				if (_operationName == null)
				{
					_operationName = (CName) CR2WTypeManager.Create("CName", "operationName", cr2w, this);
				}
				return _operationName;
			}
			set
			{
				if (_operationName == value)
				{
					return;
				}
				_operationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("resetDelay")] 
		public CBool ResetDelay
		{
			get
			{
				if (_resetDelay == null)
				{
					_resetDelay = (CBool) CR2WTypeManager.Create("Bool", "resetDelay", cr2w, this);
				}
				return _resetDelay;
			}
			set
			{
				if (_resetDelay == value)
				{
					return;
				}
				_resetDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get
			{
				if (_delayID == null)
				{
					_delayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayID", cr2w, this);
				}
				return _delayID;
			}
			set
			{
				if (_delayID == value)
				{
					return;
				}
				_delayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isDelayActive")] 
		public CBool IsDelayActive
		{
			get
			{
				if (_isDelayActive == null)
				{
					_isDelayActive = (CBool) CR2WTypeManager.Create("Bool", "isDelayActive", cr2w, this);
				}
				return _isDelayActive;
			}
			set
			{
				if (_isDelayActive == value)
				{
					return;
				}
				_isDelayActive = value;
				PropertySet(this);
			}
		}

		public OperationExecutionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
