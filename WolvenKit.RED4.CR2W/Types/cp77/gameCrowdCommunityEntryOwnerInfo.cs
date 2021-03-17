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
			get => GetProperty(ref _crowdEntryNames);
			set => SetProperty(ref _crowdEntryNames, value);
		}

		[Ordinal(1)] 
		[RED("communityId")] 
		public gameCommunityID CommunityId
		{
			get => GetProperty(ref _communityId);
			set => SetProperty(ref _communityId, value);
		}

		public gameCrowdCommunityEntryOwnerInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
