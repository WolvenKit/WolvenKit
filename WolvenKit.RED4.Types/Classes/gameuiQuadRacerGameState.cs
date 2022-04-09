using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiQuadRacerGameState : gameuiMinigameState
	{
		[Ordinal(2)] 
		[RED("timeLeft")] 
		public CFloat TimeLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("boostTime")] 
		public CFloat BoostTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("pointsBonusTime")] 
		public CFloat PointsBonusTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("hasPassedCheckpoint")] 
		public CBool HasPassedCheckpoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("shouldPushBackPlayer")] 
		public CBool ShouldPushBackPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("lapsPassed")] 
		public CInt32 LapsPassed
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiQuadRacerGameState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
