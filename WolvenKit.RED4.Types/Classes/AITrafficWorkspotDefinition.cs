using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITrafficWorkspotDefinition : worldTrafficSpotDefinition
	{
		private CResourceReference<workWorkspotResource> _workspotResource;

		[Ordinal(2)] 
		[RED("workspotResource")] 
		public CResourceReference<workWorkspotResource> WorkspotResource
		{
			get => GetProperty(ref _workspotResource);
			set => SetProperty(ref _workspotResource, value);
		}
	}
}
