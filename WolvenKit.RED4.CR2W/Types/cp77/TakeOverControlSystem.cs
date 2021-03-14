using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TakeOverControlSystem : gameScriptableSystem
	{
		private wCHandle<gameObject> _controlledObject;
		private CBool _isInputRegistered;
		private CBool _isInputLockedFromQuest;
		private CBool _isChainForcedFromQuest;
		private CBool _isActionButtonLocked;
		private CBool _isDeviceChainCreationLocked;
		private CArray<CName> _chainLockSources;
		private gameDelayID _tCDUpdateDelayID;
		private CFloat _tCSupdateRate;
		private CFloat _lastInputSimTime;

		[Ordinal(0)] 
		[RED("controlledObject")] 
		public wCHandle<gameObject> ControlledObject
		{
			get
			{
				if (_controlledObject == null)
				{
					_controlledObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "controlledObject", cr2w, this);
				}
				return _controlledObject;
			}
			set
			{
				if (_controlledObject == value)
				{
					return;
				}
				_controlledObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInputRegistered")] 
		public CBool IsInputRegistered
		{
			get
			{
				if (_isInputRegistered == null)
				{
					_isInputRegistered = (CBool) CR2WTypeManager.Create("Bool", "isInputRegistered", cr2w, this);
				}
				return _isInputRegistered;
			}
			set
			{
				if (_isInputRegistered == value)
				{
					return;
				}
				_isInputRegistered = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isInputLockedFromQuest")] 
		public CBool IsInputLockedFromQuest
		{
			get
			{
				if (_isInputLockedFromQuest == null)
				{
					_isInputLockedFromQuest = (CBool) CR2WTypeManager.Create("Bool", "isInputLockedFromQuest", cr2w, this);
				}
				return _isInputLockedFromQuest;
			}
			set
			{
				if (_isInputLockedFromQuest == value)
				{
					return;
				}
				_isInputLockedFromQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isChainForcedFromQuest")] 
		public CBool IsChainForcedFromQuest
		{
			get
			{
				if (_isChainForcedFromQuest == null)
				{
					_isChainForcedFromQuest = (CBool) CR2WTypeManager.Create("Bool", "isChainForcedFromQuest", cr2w, this);
				}
				return _isChainForcedFromQuest;
			}
			set
			{
				if (_isChainForcedFromQuest == value)
				{
					return;
				}
				_isChainForcedFromQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isActionButtonLocked")] 
		public CBool IsActionButtonLocked
		{
			get
			{
				if (_isActionButtonLocked == null)
				{
					_isActionButtonLocked = (CBool) CR2WTypeManager.Create("Bool", "isActionButtonLocked", cr2w, this);
				}
				return _isActionButtonLocked;
			}
			set
			{
				if (_isActionButtonLocked == value)
				{
					return;
				}
				_isActionButtonLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isDeviceChainCreationLocked")] 
		public CBool IsDeviceChainCreationLocked
		{
			get
			{
				if (_isDeviceChainCreationLocked == null)
				{
					_isDeviceChainCreationLocked = (CBool) CR2WTypeManager.Create("Bool", "isDeviceChainCreationLocked", cr2w, this);
				}
				return _isDeviceChainCreationLocked;
			}
			set
			{
				if (_isDeviceChainCreationLocked == value)
				{
					return;
				}
				_isDeviceChainCreationLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("chainLockSources")] 
		public CArray<CName> ChainLockSources
		{
			get
			{
				if (_chainLockSources == null)
				{
					_chainLockSources = (CArray<CName>) CR2WTypeManager.Create("array:CName", "chainLockSources", cr2w, this);
				}
				return _chainLockSources;
			}
			set
			{
				if (_chainLockSources == value)
				{
					return;
				}
				_chainLockSources = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("TCDUpdateDelayID")] 
		public gameDelayID TCDUpdateDelayID
		{
			get
			{
				if (_tCDUpdateDelayID == null)
				{
					_tCDUpdateDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "TCDUpdateDelayID", cr2w, this);
				}
				return _tCDUpdateDelayID;
			}
			set
			{
				if (_tCDUpdateDelayID == value)
				{
					return;
				}
				_tCDUpdateDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("TCSupdateRate")] 
		public CFloat TCSupdateRate
		{
			get
			{
				if (_tCSupdateRate == null)
				{
					_tCSupdateRate = (CFloat) CR2WTypeManager.Create("Float", "TCSupdateRate", cr2w, this);
				}
				return _tCSupdateRate;
			}
			set
			{
				if (_tCSupdateRate == value)
				{
					return;
				}
				_tCSupdateRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lastInputSimTime")] 
		public CFloat LastInputSimTime
		{
			get
			{
				if (_lastInputSimTime == null)
				{
					_lastInputSimTime = (CFloat) CR2WTypeManager.Create("Float", "lastInputSimTime", cr2w, this);
				}
				return _lastInputSimTime;
			}
			set
			{
				if (_lastInputSimTime == value)
				{
					return;
				}
				_lastInputSimTime = value;
				PropertySet(this);
			}
		}

		public TakeOverControlSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
