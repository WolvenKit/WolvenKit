using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BonusCollisionLogic : gameuiSideScrollerMiniGameCollisionLogic
	{
		private CBool _hasTriggered;

		[Ordinal(3)] 
		[RED("hasTriggered")] 
		public CBool HasTriggered
		{
			get => GetProperty(ref _hasTriggered);
			set => SetProperty(ref _hasTriggered, value);
		}

		public BonusCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
