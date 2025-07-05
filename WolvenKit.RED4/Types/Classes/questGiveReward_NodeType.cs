using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questGiveReward_NodeType : questIRewardManagerNodeType
	{
		[Ordinal(0)] 
		[RED("rewards")] 
		public CArray<TweakDBID> Rewards
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public questGiveReward_NodeType()
		{
			Rewards = new() { 0 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
