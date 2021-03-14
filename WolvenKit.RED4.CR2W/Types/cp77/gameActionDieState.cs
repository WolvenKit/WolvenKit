using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionDieState : gameActionReplicatedState
	{
		private wCHandle<gameObject> _owner;
		private wCHandle<moveComponent> _movingAgent;
		private wCHandle<entRagdollComponent> _ragdollComponent;
		private wCHandle<entSlotComponent> _slotComponent;

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("movingAgent")] 
		public wCHandle<moveComponent> MovingAgent
		{
			get
			{
				if (_movingAgent == null)
				{
					_movingAgent = (wCHandle<moveComponent>) CR2WTypeManager.Create("whandle:moveComponent", "movingAgent", cr2w, this);
				}
				return _movingAgent;
			}
			set
			{
				if (_movingAgent == value)
				{
					return;
				}
				_movingAgent = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ragdollComponent")] 
		public wCHandle<entRagdollComponent> RagdollComponent
		{
			get
			{
				if (_ragdollComponent == null)
				{
					_ragdollComponent = (wCHandle<entRagdollComponent>) CR2WTypeManager.Create("whandle:entRagdollComponent", "ragdollComponent", cr2w, this);
				}
				return _ragdollComponent;
			}
			set
			{
				if (_ragdollComponent == value)
				{
					return;
				}
				_ragdollComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("slotComponent")] 
		public wCHandle<entSlotComponent> SlotComponent
		{
			get
			{
				if (_slotComponent == null)
				{
					_slotComponent = (wCHandle<entSlotComponent>) CR2WTypeManager.Create("whandle:entSlotComponent", "slotComponent", cr2w, this);
				}
				return _slotComponent;
			}
			set
			{
				if (_slotComponent == value)
				{
					return;
				}
				_slotComponent = value;
				PropertySet(this);
			}
		}

		public gameActionDieState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
