using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateSnapshot : CVariable
	{
		private CName _stateMachineName;
		private CName _stateName;
		private gamestateMachineStateMachineInstanceData _instanceData;
		private CBool _running;
		private CBool _logicalOwnerIsAWeapon;
		private CBool _transitionJustHappened;

		[Ordinal(0)] 
		[RED("stateMachineName")] 
		public CName StateMachineName
		{
			get
			{
				if (_stateMachineName == null)
				{
					_stateMachineName = (CName) CR2WTypeManager.Create("CName", "stateMachineName", cr2w, this);
				}
				return _stateMachineName;
			}
			set
			{
				if (_stateMachineName == value)
				{
					return;
				}
				_stateMachineName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stateName")] 
		public CName StateName
		{
			get
			{
				if (_stateName == null)
				{
					_stateName = (CName) CR2WTypeManager.Create("CName", "stateName", cr2w, this);
				}
				return _stateName;
			}
			set
			{
				if (_stateName == value)
				{
					return;
				}
				_stateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("instanceData")] 
		public gamestateMachineStateMachineInstanceData InstanceData
		{
			get
			{
				if (_instanceData == null)
				{
					_instanceData = (gamestateMachineStateMachineInstanceData) CR2WTypeManager.Create("gamestateMachineStateMachineInstanceData", "instanceData", cr2w, this);
				}
				return _instanceData;
			}
			set
			{
				if (_instanceData == value)
				{
					return;
				}
				_instanceData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("running")] 
		public CBool Running
		{
			get
			{
				if (_running == null)
				{
					_running = (CBool) CR2WTypeManager.Create("Bool", "running", cr2w, this);
				}
				return _running;
			}
			set
			{
				if (_running == value)
				{
					return;
				}
				_running = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("logicalOwnerIsAWeapon")] 
		public CBool LogicalOwnerIsAWeapon
		{
			get
			{
				if (_logicalOwnerIsAWeapon == null)
				{
					_logicalOwnerIsAWeapon = (CBool) CR2WTypeManager.Create("Bool", "logicalOwnerIsAWeapon", cr2w, this);
				}
				return _logicalOwnerIsAWeapon;
			}
			set
			{
				if (_logicalOwnerIsAWeapon == value)
				{
					return;
				}
				_logicalOwnerIsAWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("transitionJustHappened")] 
		public CBool TransitionJustHappened
		{
			get
			{
				if (_transitionJustHappened == null)
				{
					_transitionJustHappened = (CBool) CR2WTypeManager.Create("Bool", "transitionJustHappened", cr2w, this);
				}
				return _transitionJustHappened;
			}
			set
			{
				if (_transitionJustHappened == value)
				{
					return;
				}
				_transitionJustHappened = value;
				PropertySet(this);
			}
		}

		public gamestateMachineStateSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
