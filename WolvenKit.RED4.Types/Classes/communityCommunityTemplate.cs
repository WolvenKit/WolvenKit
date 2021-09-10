using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityCommunityTemplate : CResource
	{
		[Ordinal(1)] 
		[RED("communityTemplate")] 
		public CHandle<communityCommunityTemplateData> CommunityTemplate
		{
			get => GetPropertyValue<CHandle<communityCommunityTemplateData>>();
			set => SetPropertyValue<CHandle<communityCommunityTemplateData>>(value);
		}
	}
}
