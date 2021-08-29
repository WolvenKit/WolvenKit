using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectWorkspotDefinition : gameSmartObjectDefinition
	{
		private CResourceReference<workWorkspotResource> _workspotTemplate;

		[Ordinal(5)] 
		[RED("workspotTemplate")] 
		public CResourceReference<workWorkspotResource> WorkspotTemplate
		{
			get => GetProperty(ref _workspotTemplate);
			set => SetProperty(ref _workspotTemplate, value);
		}
	}
}
