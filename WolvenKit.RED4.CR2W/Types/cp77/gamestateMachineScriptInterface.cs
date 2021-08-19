using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineScriptInterface : IScriptable
	{
		private wCHandle<gameObject> _owner;
		private wCHandle<gameObject> _executionOwner;
		private wCHandle<gameIBlackboard> _localBlackboard;
		private entEntityID _ownerEntityID;
		private entEntityID _executionOwnerEntityID;
		private CHandle<gamebbScriptDefinition> _stateMachineBBDef;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("executionOwner")] 
		public wCHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(2)] 
		[RED("localBlackboard")] 
		public wCHandle<gameIBlackboard> LocalBlackboard
		{
			get => GetProperty(ref _localBlackboard);
			set => SetProperty(ref _localBlackboard, value);
		}

		[Ordinal(3)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetProperty(ref _ownerEntityID);
			set => SetProperty(ref _ownerEntityID, value);
		}

		[Ordinal(4)] 
		[RED("executionOwnerEntityID")] 
		public entEntityID ExecutionOwnerEntityID
		{
			get => GetProperty(ref _executionOwnerEntityID);
			set => SetProperty(ref _executionOwnerEntityID, value);
		}

		[Ordinal(5)] 
		[RED("stateMachineBBDef")] 
		public CHandle<gamebbScriptDefinition> StateMachineBBDef
		{
			get => GetProperty(ref _stateMachineBBDef);
			set => SetProperty(ref _stateMachineBBDef, value);
		}

		public gamestateMachineScriptInterface(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
