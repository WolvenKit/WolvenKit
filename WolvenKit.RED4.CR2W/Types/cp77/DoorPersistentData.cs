using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorPersistentData : CVariable
	{
		private CEnum<EDoorType> _doorType;
		private CBool _canPlayerToggleLockState;
		private CBool _canPlayerToggleSealState;
		private CEnum<EDoorStatus> _initialStatus;
		private TweakDBID _keycardName;
		private CName _passcode;

		[Ordinal(0)] 
		[RED("doorType")] 
		public CEnum<EDoorType> DoorType
		{
			get
			{
				if (_doorType == null)
				{
					_doorType = (CEnum<EDoorType>) CR2WTypeManager.Create("EDoorType", "doorType", cr2w, this);
				}
				return _doorType;
			}
			set
			{
				if (_doorType == value)
				{
					return;
				}
				_doorType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("canPlayerToggleLockState")] 
		public CBool CanPlayerToggleLockState
		{
			get
			{
				if (_canPlayerToggleLockState == null)
				{
					_canPlayerToggleLockState = (CBool) CR2WTypeManager.Create("Bool", "canPlayerToggleLockState", cr2w, this);
				}
				return _canPlayerToggleLockState;
			}
			set
			{
				if (_canPlayerToggleLockState == value)
				{
					return;
				}
				_canPlayerToggleLockState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("canPlayerToggleSealState")] 
		public CBool CanPlayerToggleSealState
		{
			get
			{
				if (_canPlayerToggleSealState == null)
				{
					_canPlayerToggleSealState = (CBool) CR2WTypeManager.Create("Bool", "canPlayerToggleSealState", cr2w, this);
				}
				return _canPlayerToggleSealState;
			}
			set
			{
				if (_canPlayerToggleSealState == value)
				{
					return;
				}
				_canPlayerToggleSealState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("initialStatus")] 
		public CEnum<EDoorStatus> InitialStatus
		{
			get
			{
				if (_initialStatus == null)
				{
					_initialStatus = (CEnum<EDoorStatus>) CR2WTypeManager.Create("EDoorStatus", "initialStatus", cr2w, this);
				}
				return _initialStatus;
			}
			set
			{
				if (_initialStatus == value)
				{
					return;
				}
				_initialStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("keycardName")] 
		public TweakDBID KeycardName
		{
			get
			{
				if (_keycardName == null)
				{
					_keycardName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "keycardName", cr2w, this);
				}
				return _keycardName;
			}
			set
			{
				if (_keycardName == value)
				{
					return;
				}
				_keycardName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("passcode")] 
		public CName Passcode
		{
			get
			{
				if (_passcode == null)
				{
					_passcode = (CName) CR2WTypeManager.Create("CName", "passcode", cr2w, this);
				}
				return _passcode;
			}
			set
			{
				if (_passcode == value)
				{
					return;
				}
				_passcode = value;
				PropertySet(this);
			}
		}

		public DoorPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
