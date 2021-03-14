using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorControllerPS : ScriptableDeviceComponentPS
	{
		private DoorSetup _doorProperties;
		private CHandle<EngDemoContainer> _doorSkillChecks;
		private CBool _isOpened;
		private CBool _isLocked;
		private CBool _isSealed;
		private CBool _alarmRaised;
		private CBool _isBusy;
		private CBool _isLiftDoor;
		private CBool _isPlayerAuthorised;
		private CArray<entEntityID> _openingTokens;

		[Ordinal(103)] 
		[RED("doorProperties")] 
		public DoorSetup DoorProperties
		{
			get
			{
				if (_doorProperties == null)
				{
					_doorProperties = (DoorSetup) CR2WTypeManager.Create("DoorSetup", "doorProperties", cr2w, this);
				}
				return _doorProperties;
			}
			set
			{
				if (_doorProperties == value)
				{
					return;
				}
				_doorProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("doorSkillChecks")] 
		public CHandle<EngDemoContainer> DoorSkillChecks
		{
			get
			{
				if (_doorSkillChecks == null)
				{
					_doorSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "doorSkillChecks", cr2w, this);
				}
				return _doorSkillChecks;
			}
			set
			{
				if (_doorSkillChecks == value)
				{
					return;
				}
				_doorSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("isOpened")] 
		public CBool IsOpened
		{
			get
			{
				if (_isOpened == null)
				{
					_isOpened = (CBool) CR2WTypeManager.Create("Bool", "isOpened", cr2w, this);
				}
				return _isOpened;
			}
			set
			{
				if (_isOpened == value)
				{
					return;
				}
				_isOpened = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("isSealed")] 
		public CBool IsSealed
		{
			get
			{
				if (_isSealed == null)
				{
					_isSealed = (CBool) CR2WTypeManager.Create("Bool", "isSealed", cr2w, this);
				}
				return _isSealed;
			}
			set
			{
				if (_isSealed == value)
				{
					return;
				}
				_isSealed = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("alarmRaised")] 
		public CBool AlarmRaised
		{
			get
			{
				if (_alarmRaised == null)
				{
					_alarmRaised = (CBool) CR2WTypeManager.Create("Bool", "alarmRaised", cr2w, this);
				}
				return _alarmRaised;
			}
			set
			{
				if (_alarmRaised == value)
				{
					return;
				}
				_alarmRaised = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("isBusy")] 
		public CBool IsBusy
		{
			get
			{
				if (_isBusy == null)
				{
					_isBusy = (CBool) CR2WTypeManager.Create("Bool", "isBusy", cr2w, this);
				}
				return _isBusy;
			}
			set
			{
				if (_isBusy == value)
				{
					return;
				}
				_isBusy = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("isLiftDoor")] 
		public CBool IsLiftDoor
		{
			get
			{
				if (_isLiftDoor == null)
				{
					_isLiftDoor = (CBool) CR2WTypeManager.Create("Bool", "isLiftDoor", cr2w, this);
				}
				return _isLiftDoor;
			}
			set
			{
				if (_isLiftDoor == value)
				{
					return;
				}
				_isLiftDoor = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("isPlayerAuthorised")] 
		public CBool IsPlayerAuthorised
		{
			get
			{
				if (_isPlayerAuthorised == null)
				{
					_isPlayerAuthorised = (CBool) CR2WTypeManager.Create("Bool", "isPlayerAuthorised", cr2w, this);
				}
				return _isPlayerAuthorised;
			}
			set
			{
				if (_isPlayerAuthorised == value)
				{
					return;
				}
				_isPlayerAuthorised = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("openingTokens")] 
		public CArray<entEntityID> OpeningTokens
		{
			get
			{
				if (_openingTokens == null)
				{
					_openingTokens = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "openingTokens", cr2w, this);
				}
				return _openingTokens;
			}
			set
			{
				if (_openingTokens == value)
				{
					return;
				}
				_openingTokens = value;
				PropertySet(this);
			}
		}

		public DoorControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
