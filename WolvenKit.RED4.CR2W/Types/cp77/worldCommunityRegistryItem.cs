using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCommunityRegistryItem : CVariable
	{
		private CArray<worldCommunityEntryInitialState> _entriesInitialState;
		private CHandle<communityCommunityTemplateData> _template;
		private gameCommunityID _communityId;
		private CBool _communityIsBackground;

		[Ordinal(0)] 
		[RED("entriesInitialState")] 
		public CArray<worldCommunityEntryInitialState> EntriesInitialState
		{
			get
			{
				if (_entriesInitialState == null)
				{
					_entriesInitialState = (CArray<worldCommunityEntryInitialState>) CR2WTypeManager.Create("array:worldCommunityEntryInitialState", "entriesInitialState", cr2w, this);
				}
				return _entriesInitialState;
			}
			set
			{
				if (_entriesInitialState == value)
				{
					return;
				}
				_entriesInitialState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("template")] 
		public CHandle<communityCommunityTemplateData> Template
		{
			get
			{
				if (_template == null)
				{
					_template = (CHandle<communityCommunityTemplateData>) CR2WTypeManager.Create("handle:communityCommunityTemplateData", "template", cr2w, this);
				}
				return _template;
			}
			set
			{
				if (_template == value)
				{
					return;
				}
				_template = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("communityId")] 
		public gameCommunityID CommunityId
		{
			get
			{
				if (_communityId == null)
				{
					_communityId = (gameCommunityID) CR2WTypeManager.Create("gameCommunityID", "communityId", cr2w, this);
				}
				return _communityId;
			}
			set
			{
				if (_communityId == value)
				{
					return;
				}
				_communityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("communityIsBackground")] 
		public CBool CommunityIsBackground
		{
			get
			{
				if (_communityIsBackground == null)
				{
					_communityIsBackground = (CBool) CR2WTypeManager.Create("Bool", "communityIsBackground", cr2w, this);
				}
				return _communityIsBackground;
			}
			set
			{
				if (_communityIsBackground == value)
				{
					return;
				}
				_communityIsBackground = value;
				PropertySet(this);
			}
		}

		public worldCommunityRegistryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
