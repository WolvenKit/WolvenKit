using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectWorkspotDefinition : gameSmartObjectDefinition
	{
		[Ordinal(5)] 
		[RED("workspotTemplate")] 
		public CResourceReference<workWorkspotResource> WorkspotTemplate
		{
			get => GetPropertyValue<CResourceReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceReference<workWorkspotResource>>(value);
		}
	}
}
