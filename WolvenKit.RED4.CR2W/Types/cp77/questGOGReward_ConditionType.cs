using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questGOGReward_ConditionType : questISystemConditionType
	{
		private TweakDBID _rewardRecordId;

		[Ordinal(0)] 
		[RED("rewardRecordId")] 
		public TweakDBID RewardRecordId
		{
			get
			{
				if (_rewardRecordId == null)
				{
					_rewardRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "rewardRecordId", cr2w, this);
				}
				return _rewardRecordId;
			}
			set
			{
				if (_rewardRecordId == value)
				{
					return;
				}
				_rewardRecordId = value;
				PropertySet(this);
			}
		}

		public questGOGReward_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
