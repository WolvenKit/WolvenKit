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

		public gamestateMachineScriptInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
