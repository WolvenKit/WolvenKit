using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questGOGReward_ConditionType : questISystemConditionType
	{
		private TweakDBID _rewardRecordId;

		[Ordinal(0)] 
		[RED("rewardRecordId")] 
		public TweakDBID RewardRecordId
		{
			get => GetProperty(ref _rewardRecordId);
			set => SetProperty(ref _rewardRecordId, value);
		}
	}
}
