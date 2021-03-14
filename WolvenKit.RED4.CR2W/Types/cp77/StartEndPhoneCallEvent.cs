using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StartEndPhoneCallEvent : redEvent
	{
		private CFloat _callDuration;
		private CBool _startCall;
		private CEnum<gamedataStatType> _statType;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CString _statPoolName;

		[Ordinal(0)] 
		[RED("callDuration")] 
		public CFloat CallDuration
		{
			get
			{
				if (_callDuration == null)
				{
					_callDuration = (CFloat) CR2WTypeManager.Create("Float", "callDuration", cr2w, this);
				}
				return _callDuration;
			}
			set
			{
				if (_callDuration == value)
				{
					return;
				}
				_callDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startCall")] 
		public CBool StartCall
		{
			get
			{
				if (_startCall == null)
				{
					_startCall = (CBool) CR2WTypeManager.Create("Bool", "startCall", cr2w, this);
				}
				return _startCall;
			}
			set
			{
				if (_startCall == value)
				{
					return;
				}
				_startCall = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get
			{
				if (_statType == null)
				{
					_statType = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "statType", cr2w, this);
				}
				return _statType;
			}
			set
			{
				if (_statType == value)
				{
					return;
				}
				_statType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get
			{
				if (_statPoolType == null)
				{
					_statPoolType = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolType", cr2w, this);
				}
				return _statPoolType;
			}
			set
			{
				if (_statPoolType == value)
				{
					return;
				}
				_statPoolType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("statPoolName")] 
		public CString StatPoolName
		{
			get
			{
				if (_statPoolName == null)
				{
					_statPoolName = (CString) CR2WTypeManager.Create("String", "statPoolName", cr2w, this);
				}
				return _statPoolName;
			}
			set
			{
				if (_statPoolName == value)
				{
					return;
				}
				_statPoolName = value;
				PropertySet(this);
			}
		}

		public StartEndPhoneCallEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
