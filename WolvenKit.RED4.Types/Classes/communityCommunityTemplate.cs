using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityCommunityTemplate : CResource
	{
		private CHandle<communityCommunityTemplateData> _communityTemplate;

		[Ordinal(1)] 
		[RED("communityTemplate")] 
		public CHandle<communityCommunityTemplateData> CommunityTemplate
		{
			get => GetProperty(ref _communityTemplate);
			set => SetProperty(ref _communityTemplate, value);
		}
	}
}
