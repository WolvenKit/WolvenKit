using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questGiveReward_NodeType : questIRewardManagerNodeType
	{
		private CArray<TweakDBID> _rewards;

		[Ordinal(0)] 
		[RED("rewards")] 
		public CArray<TweakDBID> Rewards
		{
			get => GetProperty(ref _rewards);
			set => SetProperty(ref _rewards, value);
		}
	}
}
