using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorConvertToDynamicWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _spotInstance;
		private CHandle<AIArgumentMapping> _jumpToEntry;
		private CHandle<AIArgumentMapping> _entryId;

		[Ordinal(1)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(2)] 
		[RED("spotInstance")] 
		public CHandle<AIArgumentMapping> SpotInstance
		{
			get => GetProperty(ref _spotInstance);
			set => SetProperty(ref _spotInstance, value);
		}

		[Ordinal(3)] 
		[RED("jumpToEntry")] 
		public CHandle<AIArgumentMapping> JumpToEntry
		{
			get => GetProperty(ref _jumpToEntry);
			set => SetProperty(ref _jumpToEntry, value);
		}

		[Ordinal(4)] 
		[RED("entryId")] 
		public CHandle<AIArgumentMapping> EntryId
		{
			get => GetProperty(ref _entryId);
			set => SetProperty(ref _entryId, value);
		}
	}
}
