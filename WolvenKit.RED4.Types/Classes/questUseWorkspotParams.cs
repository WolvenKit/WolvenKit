using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUseWorkspotParams : RedBaseClass
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
	}
}
