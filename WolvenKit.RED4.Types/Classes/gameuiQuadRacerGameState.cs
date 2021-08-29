using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiQuadRacerGameState : gameuiMinigameState
	{
		private CFloat _timeLeft;
		private CFloat _boostTime;
		private CFloat _pointsBonusTime;
		private CFloat _maxSpeed;
		private CFloat _speed;
		private CBool _hasPassedCheckpoint;
		private CBool _shouldPushBackPlayer;
		private CInt32 _lapsPassed;

		[Ordinal(2)] 
		[RED("timeLeft")] 
		public CFloat TimeLeft
		{
			get => GetProperty(ref _timeLeft);
			set => SetProperty(ref _timeLeft, value);
		}

		[Ordinal(3)] 
		[RED("boostTime")] 
		public CFloat BoostTime
		{
			get => GetProperty(ref _boostTime);
			set => SetProperty(ref _boostTime, value);
		}

		[Ordinal(4)] 
		[RED("pointsBonusTime")] 
		public CFloat PointsBonusTime
		{
			get => GetProperty(ref _pointsBonusTime);
			set => SetProperty(ref _pointsBonusTime, value);
		}

		[Ordinal(5)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(6)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(7)] 
		[RED("hasPassedCheckpoint")] 
		public CBool HasPassedCheckpoint
		{
			get => GetProperty(ref _hasPassedCheckpoint);
			set => SetProperty(ref _hasPassedCheckpoint, value);
		}

		[Ordinal(8)] 
		[RED("shouldPushBackPlayer")] 
		public CBool ShouldPushBackPlayer
		{
			get => GetProperty(ref _shouldPushBackPlayer);
			set => SetProperty(ref _shouldPushBackPlayer, value);
		}

		[Ordinal(9)] 
		[RED("lapsPassed")] 
		public CInt32 LapsPassed
		{
			get => GetProperty(ref _lapsPassed);
			set => SetProperty(ref _lapsPassed, value);
		}
	}
}
