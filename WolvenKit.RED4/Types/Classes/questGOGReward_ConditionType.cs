using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questGOGReward_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("rewardRecordId")] 
		public TweakDBID RewardRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questGOGReward_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
