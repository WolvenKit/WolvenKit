using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityCommunityTemplate : CResource
	{
		private CHandle<communityCommunityTemplateData> _communityTemplate;

		[Ordinal(1)] 
		[RED("communityTemplate")] 
		public CHandle<communityCommunityTemplateData> CommunityTemplate
		{
			get => GetProperty(ref _communityTemplate);
			set => SetProperty(ref _communityTemplate, value);
		}

		public communityCommunityTemplate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
