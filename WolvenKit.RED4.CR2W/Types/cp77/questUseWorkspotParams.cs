using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotParams : CVariable
	{
		private NodeRef _workspotNode;
		private CName _forceEntryAnimName;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get
			{
				if (_forceEntryAnimName == null)
				{
					_forceEntryAnimName = (CName) CR2WTypeManager.Create("CName", "forceEntryAnimName", cr2w, this);
				}
				return _forceEntryAnimName;
			}
			set
			{
				if (_forceEntryAnimName == value)
				{
					return;
				}
				_forceEntryAnimName = value;
				PropertySet(this);
			}
		}

		public questUseWorkspotParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
