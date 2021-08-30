using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ObstacleCollisionLogic : gameuiSideScrollerMiniGameCollisionLogic
	{
		private CBool _hasTriggered;
		private CFloat _invincibityBonusTime;

		[Ordinal(3)] 
		[RED("hasTriggered")] 
		public CBool HasTriggered
		{
			get => GetProperty(ref _hasTriggered);
			set => SetProperty(ref _hasTriggered, value);
		}

		[Ordinal(4)] 
		[RED("invincibityBonusTime")] 
		public CFloat InvincibityBonusTime
		{
			get => GetProperty(ref _invincibityBonusTime);
			set => SetProperty(ref _invincibityBonusTime, value);
		}

		public ObstacleCollisionLogic()
		{
			_invincibityBonusTime = 0.800000F;
		}
	}
}
