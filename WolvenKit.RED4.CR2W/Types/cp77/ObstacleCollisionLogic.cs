using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ObstacleCollisionLogic : gameuiSideScrollerMiniGameCollisionLogic
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

		public ObstacleCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
