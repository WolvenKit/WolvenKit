using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotResource : animAnimGraph
	{
		private CHandle<workWorkspotTree> _workspotTree;

		[Ordinal(16)] 
		[RED("workspotTree")] 
		public CHandle<workWorkspotTree> WorkspotTree
		{
			get => GetProperty(ref _workspotTree);
			set => SetProperty(ref _workspotTree, value);
		}
	}
}
