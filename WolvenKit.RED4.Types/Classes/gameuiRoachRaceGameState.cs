using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRoachRaceGameState : gameuiMinigameState
	{
		private CFloat _invincibleTime;
		private CFloat _pointsBonusTime;
		private CFloat _speedMultiplicator;

		[Ordinal(2)] 
		[RED("invincibleTime")] 
		public CFloat InvincibleTime
		{
			get => GetProperty(ref _invincibleTime);
			set => SetProperty(ref _invincibleTime, value);
		}

		[Ordinal(3)] 
		[RED("pointsBonusTime")] 
		public CFloat PointsBonusTime
		{
			get => GetProperty(ref _pointsBonusTime);
			set => SetProperty(ref _pointsBonusTime, value);
		}

		[Ordinal(4)] 
		[RED("speedMultiplicator")] 
		public CFloat SpeedMultiplicator
		{
			get => GetProperty(ref _speedMultiplicator);
			set => SetProperty(ref _speedMultiplicator, value);
		}
	}
}
