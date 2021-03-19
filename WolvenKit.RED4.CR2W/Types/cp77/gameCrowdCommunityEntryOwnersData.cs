using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdCommunityEntryOwnersData : CVariable
	{
		private CArray<gameCrowdCommunityEntryOwnerInfo> _communityOwnersData;

		[Ordinal(0)] 
		[RED("communityOwnersData")] 
		public CArray<gameCrowdCommunityEntryOwnerInfo> CommunityOwnersData
		{
			get => GetProperty(ref _communityOwnersData);
			set => SetProperty(ref _communityOwnersData, value);
		}

		public gameCrowdCommunityEntryOwnersData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
