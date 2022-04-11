using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotResource : animAnimGraph
	{
		[Ordinal(16)] 
		[RED("workspotTree")] 
		public CHandle<workWorkspotTree> WorkspotTree
		{
			get => GetPropertyValue<CHandle<workWorkspotTree>>();
			set => SetPropertyValue<CHandle<workWorkspotTree>>(value);
		}
	}
}
