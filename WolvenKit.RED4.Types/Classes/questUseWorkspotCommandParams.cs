using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUseWorkspotCommandParams : questAICommandParams
	{
		private NodeRef _workspotNode;
		private CBool _moveToWorkspot;
		private CName _forceEntryAnimName;

		[Ordinal(0)] 
		[RED("workspotNode")] 
		public NodeRef WorkspotNode
		{
			get => GetProperty(ref _workspotNode);
			set => SetProperty(ref _workspotNode, value);
		}

		[Ordinal(1)] 
		[RED("moveToWorkspot")] 
		public CBool MoveToWorkspot
		{
			get => GetProperty(ref _moveToWorkspot);
			set => SetProperty(ref _moveToWorkspot, value);
		}

		[Ordinal(2)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get => GetProperty(ref _forceEntryAnimName);
			set => SetProperty(ref _forceEntryAnimName, value);
		}
	}
}
