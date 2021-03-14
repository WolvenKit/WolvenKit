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
			get
			{
				if (_workspotNode == null)
				{
					_workspotNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "workspotNode", cr2w, this);
				}
				return _workspotNode;
			}
			set
			{
				if (_workspotNode == value)
				{
					return;
				}
				_workspotNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("jumpToEntry")] 
		public CBool JumpToEntry
		{
			get
			{
				if (_jumpToEntry == null)
				{
					_jumpToEntry = (CBool) CR2WTypeManager.Create("Bool", "jumpToEntry", cr2w, this);
				}
				return _jumpToEntry;
			}
			set
			{
				if (_jumpToEntry == value)
				{
					return;
				}
				_jumpToEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("entryId")] 
		public workWorkEntryId EntryId
		{
			get
			{
				if (_entryId == null)
				{
					_entryId = (workWorkEntryId) CR2WTypeManager.Create("workWorkEntryId", "entryId", cr2w, this);
				}
				return _entryId;
			}
			set
			{
				if (_entryId == value)
				{
					return;
				}
				_entryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("entryTag")] 
		public CName EntryTag
		{
			get
			{
				if (_entryTag == null)
				{
					_entryTag = (CName) CR2WTypeManager.Create("CName", "entryTag", cr2w, this);
				}
				return _entryTag;
			}
			set
			{
				if (_entryTag == value)
				{
					return;
				}
				_entryTag = value;
				PropertySet(this);
			}
		}

		public AIUseWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
