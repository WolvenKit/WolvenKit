using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WrappedGOGRewardPack : IScriptable
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CUInt64 Index
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public gameRewardPack Data
		{
			get => GetPropertyValue<gameRewardPack>();
			set => SetPropertyValue<gameRewardPack>(value);
		}

		public WrappedGOGRewardPack()
		{
			Data = new gameRewardPack { Rewards = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
