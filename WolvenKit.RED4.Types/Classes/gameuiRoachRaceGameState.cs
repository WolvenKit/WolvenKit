using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRoachRaceGameState : gameuiMinigameState
	{
		[Ordinal(2)] 
		[RED("invincibleTime")] 
		public CFloat InvincibleTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("pointsBonusTime")] 
		public CFloat PointsBonusTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("speedMultiplicator")] 
		public CFloat SpeedMultiplicator
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiRoachRaceGameState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
