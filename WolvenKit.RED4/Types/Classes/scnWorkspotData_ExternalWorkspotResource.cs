using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnWorkspotData_ExternalWorkspotResource : scnWorkspotData
	{
		[Ordinal(1)] 
		[RED("workspotResource")] 
		public CResourceReference<workWorkspotResource> WorkspotResource
		{
			get => GetPropertyValue<CResourceReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceReference<workWorkspotResource>>(value);
		}

		public scnWorkspotData_ExternalWorkspotResource()
		{
			DataId = new scnSceneWorkspotDataId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
