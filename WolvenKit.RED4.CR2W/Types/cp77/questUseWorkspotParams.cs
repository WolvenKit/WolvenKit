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
			get => GetProperty(ref _workspotNode);
			set => SetProperty(ref _workspotNode, value);
		}

		[Ordinal(1)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get => GetProperty(ref _forceEntryAnimName);
			set => SetProperty(ref _forceEntryAnimName, value);
		}

		public questUseWorkspotParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
