using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITrafficWorkspotDefinition : worldTrafficSpotDefinition
	{
		[Ordinal(2)] 
		[RED("workspotResource")] 
		public CResourceReference<workWorkspotResource> WorkspotResource
		{
			get => GetPropertyValue<CResourceReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceReference<workWorkspotResource>>(value);
		}

		public AITrafficWorkspotDefinition()
		{
			Direction = Enums.worldTrafficSpotDirection.Both;
		}
	}
}
