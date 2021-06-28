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
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(6)] 
		[RED("movingAgent")] 
		public wCHandle<moveComponent> MovingAgent
		{
			get => GetProperty(ref _movingAgent);
			set => SetProperty(ref _movingAgent, value);
		}

		[Ordinal(7)] 
		[RED("ragdollComponent")] 
		public wCHandle<entRagdollComponent> RagdollComponent
		{
			get => GetProperty(ref _ragdollComponent);
			set => SetProperty(ref _ragdollComponent, value);
		}

		[Ordinal(8)] 
		[RED("slotComponent")] 
		public wCHandle<entSlotComponent> SlotComponent
		{
			get => GetProperty(ref _slotComponent);
			set => SetProperty(ref _slotComponent, value);
		}

		public gameActionDieState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
