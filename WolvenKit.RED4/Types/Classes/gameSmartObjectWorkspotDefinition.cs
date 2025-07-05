using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSmartObjectWorkspotDefinition : gameSmartObjectDefinition
	{
		[Ordinal(5)] 
		[RED("workspotTemplate")] 
		public CResourceReference<workWorkspotResource> WorkspotTemplate
		{
			get => GetPropertyValue<CResourceReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceReference<workWorkspotResource>>(value);
		}

		public gameSmartObjectWorkspotDefinition()
		{
			WorkspotTemplate = new CResourceReference<workWorkspotResource>(@"base\gameplay\workspots\cover_workspot.workspot");

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
