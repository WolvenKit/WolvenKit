using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ObstacleCollisionLogic : gameuiSideScrollerMiniGameCollisionLogic
	{
		[Ordinal(3)] 
		[RED("hasTriggered")] 
		public CBool HasTriggered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("invincibityBonusTime")] 
		public CFloat InvincibityBonusTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ObstacleCollisionLogic()
		{
			InvincibityBonusTime = 0.800000F;
		}
	}
}
