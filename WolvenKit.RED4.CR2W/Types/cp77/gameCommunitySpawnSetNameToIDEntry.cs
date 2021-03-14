using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCommunitySpawnSetNameToIDEntry : CVariable
	{
		private gameCommunityID _communityId;
		private CName _nameReference;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("nameReference")] 
		public CName NameReference
		{
			get
			{
				if (_nameReference == null)
				{
					_nameReference = (CName) CR2WTypeManager.Create("CName", "nameReference", cr2w, this);
				}
				return _nameReference;
			}
			set
			{
				if (_nameReference == value)
				{
					return;
				}
				_nameReference = value;
				PropertySet(this);
			}
		}

		public gameCommunitySpawnSetNameToIDEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
