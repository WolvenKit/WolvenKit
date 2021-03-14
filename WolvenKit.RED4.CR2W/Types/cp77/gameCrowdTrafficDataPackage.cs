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
			get
			{
				if (_crowdEntryOwners == null)
				{
					_crowdEntryOwners = (gameCrowdCommunityEntryOwnersData) CR2WTypeManager.Create("gameCrowdCommunityEntryOwnersData", "crowdEntryOwners", cr2w, this);
				}
				return _crowdEntryOwners;
			}
			set
			{
				if (_crowdEntryOwners == value)
				{
					return;
				}
				_crowdEntryOwners = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("crowdTrafficData")] 
		public gameCompiledCrowdTrafficData CrowdTrafficData
		{
			get
			{
				if (_crowdTrafficData == null)
				{
					_crowdTrafficData = (gameCompiledCrowdTrafficData) CR2WTypeManager.Create("gameCompiledCrowdTrafficData", "crowdTrafficData", cr2w, this);
				}
				return _crowdTrafficData;
			}
			set
			{
				if (_crowdTrafficData == value)
				{
					return;
				}
				_crowdTrafficData = value;
				PropertySet(this);
			}
		}

		public gameCrowdTrafficDataPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
