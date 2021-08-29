using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCrowdManagerNodeType_ControlCrowd : questICrowdManager_NodeType
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
	}
}
