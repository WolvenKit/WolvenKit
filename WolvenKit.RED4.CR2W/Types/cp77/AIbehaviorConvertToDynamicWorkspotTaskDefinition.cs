using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConvertToDynamicWorkspotTaskDefinition : AIbehaviorTaskDefinition
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

		public AIbehaviorConvertToDynamicWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
