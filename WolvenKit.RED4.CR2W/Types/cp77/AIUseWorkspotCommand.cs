using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIUseWorkspotCommand : AIBaseUseWorkspotCommand
	{
		private NodeRef _workspotNode;
		private CBool _jumpToEntry;
		private workWorkEntryId _entryId;
		private CName _entryTag;

		[Ordinal(11)] 
		[RED("workspotNode")] 
		public NodeRef WorkspotNode
		{
			get => GetProperty(ref _workspotNode);
			set => SetProperty(ref _workspotNode, value);
		}

		[Ordinal(12)] 
		[RED("jumpToEntry")] 
		public CBool JumpToEntry
		{
			get => GetProperty(ref _jumpToEntry);
			set => SetProperty(ref _jumpToEntry, value);
		}

		[Ordinal(13)] 
		[RED("entryId")] 
		public workWorkEntryId EntryId
		{
			get => GetProperty(ref _entryId);
			set => SetProperty(ref _entryId, value);
		}

		[Ordinal(14)] 
		[RED("entryTag")] 
		public CName EntryTag
		{
			get => GetProperty(ref _entryTag);
			set => SetProperty(ref _entryTag, value);
		}

		public AIUseWorkspotCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
