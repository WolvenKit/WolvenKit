using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCrowdManagerNodeType_ControlCrowd : questICrowdManager_NodeType
	{
		private CEnum<questControlCrowdAction> _action;
		private CName _debugSource;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questControlCrowdAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("debugSource")] 
		public CName DebugSource
		{
			get => GetProperty(ref _debugSource);
			set => SetProperty(ref _debugSource, value);
		}

		public questCrowdManagerNodeType_ControlCrowd(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
