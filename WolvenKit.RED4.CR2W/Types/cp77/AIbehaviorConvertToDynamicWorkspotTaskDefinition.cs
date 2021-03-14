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
			get
			{
				if (_workspotData == null)
				{
					_workspotData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotData", cr2w, this);
				}
				return _workspotData;
			}
			set
			{
				if (_workspotData == value)
				{
					return;
				}
				_workspotData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spotInstance")] 
		public CHandle<AIArgumentMapping> SpotInstance
		{
			get
			{
				if (_spotInstance == null)
				{
					_spotInstance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "spotInstance", cr2w, this);
				}
				return _spotInstance;
			}
			set
			{
				if (_spotInstance == value)
				{
					return;
				}
				_spotInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("jumpToEntry")] 
		public CHandle<AIArgumentMapping> JumpToEntry
		{
			get
			{
				if (_jumpToEntry == null)
				{
					_jumpToEntry = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "jumpToEntry", cr2w, this);
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

		[Ordinal(4)] 
		[RED("entryId")] 
		public CHandle<AIArgumentMapping> EntryId
		{
			get
			{
				if (_entryId == null)
				{
					_entryId = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "entryId", cr2w, this);
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

		public AIbehaviorConvertToDynamicWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
