using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdCommunityEntryOwnerInfo : CVariable
	{
		private CArray<CName> _crowdEntryNames;
		private gameCommunityID _communityId;

		[Ordinal(0)] 
		[RED("crowdEntryNames")] 
		public CArray<CName> CrowdEntryNames
		{
			get
			{
				if (_crowdEntryNames == null)
				{
					_crowdEntryNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "crowdEntryNames", cr2w, this);
				}
				return _crowdEntryNames;
			}
			set
			{
				if (_crowdEntryNames == value)
				{
					return;
				}
				_crowdEntryNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public gameCrowdCommunityEntryOwnerInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
