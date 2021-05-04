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
			get => GetProperty(ref _stateMachineName);
			set => SetProperty(ref _stateMachineName, value);
		}

		[Ordinal(1)] 
		[RED("stateName")] 
		public CName StateName
		{
			get => GetProperty(ref _stateName);
			set => SetProperty(ref _stateName, value);
		}

		[Ordinal(2)] 
		[RED("instanceData")] 
		public gamestateMachineStateMachineInstanceData InstanceData
		{
			get => GetProperty(ref _instanceData);
			set => SetProperty(ref _instanceData, value);
		}

		[Ordinal(3)] 
		[RED("running")] 
		public CBool Running
		{
			get => GetProperty(ref _running);
			set => SetProperty(ref _running, value);
		}

		[Ordinal(4)] 
		[RED("logicalOwnerIsAWeapon")] 
		public CBool LogicalOwnerIsAWeapon
		{
			get => GetProperty(ref _logicalOwnerIsAWeapon);
			set => SetProperty(ref _logicalOwnerIsAWeapon, value);
		}

		[Ordinal(5)] 
		[RED("transitionJustHappened")] 
		public CBool TransitionJustHappened
		{
			get => GetProperty(ref _transitionJustHappened);
			set => SetProperty(ref _transitionJustHappened, value);
		}

		public gamestateMachineStateSnapshot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
