using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTrafficDataPackage : CVariable
	{
		private gameCrowdCommunityEntryOwnersData _crowdEntryOwners;
		private gameCompiledCrowdTrafficData _crowdTrafficData;

		[Ordinal(0)] 
		[RED("crowdEntryOwners")] 
		public gameCrowdCommunityEntryOwnersData CrowdEntryOwners
		{
			get => GetProperty(ref _crowdEntryOwners);
			set => SetProperty(ref _crowdEntryOwners, value);
		}

		[Ordinal(1)] 
		[RED("crowdTrafficData")] 
		public gameCompiledCrowdTrafficData CrowdTrafficData
		{
			get => GetProperty(ref _crowdTrafficData);
			set => SetProperty(ref _crowdTrafficData, value);
		}

		public gameCrowdTrafficDataPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
