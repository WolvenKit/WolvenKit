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
			get
			{
				if (_communityTemplate == null)
				{
					_communityTemplate = (CHandle<communityCommunityTemplateData>) CR2WTypeManager.Create("handle:communityCommunityTemplateData", "communityTemplate", cr2w, this);
				}
				return _communityTemplate;
			}
			set
			{
				if (_communityTemplate == value)
				{
					return;
				}
				_communityTemplate = value;
				PropertySet(this);
			}
		}

		public communityCommunityTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
