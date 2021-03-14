using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventAddOnDemandStateMachine : redEvent
	{
		private CName _stateMachineName;
		private gamestateMachineStateMachineInstanceData _instanceData;
		private CBool _tryHotSwap;
		private wCHandle<gameObject> _owner;

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

		[Ordinal(2)] 
		[RED("tryHotSwap")] 
		public CBool TryHotSwap
		{
			get
			{
				if (_tryHotSwap == null)
				{
					_tryHotSwap = (CBool) CR2WTypeManager.Create("Bool", "tryHotSwap", cr2w, this);
				}
				return _tryHotSwap;
			}
			set
			{
				if (_tryHotSwap == value)
				{
					return;
				}
				_tryHotSwap = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public gamestateMachineeventAddOnDemandStateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
