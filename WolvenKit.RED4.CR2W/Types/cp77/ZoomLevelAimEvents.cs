using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoomLevelAimEvents : ZoomEventsTransition
	{
		private CBool _isAmingWithWeapon;

		[Ordinal(0)] 
		[RED("isAmingWithWeapon")] 
		public CBool IsAmingWithWeapon
		{
			get => GetProperty(ref _isAmingWithWeapon);
			set => SetProperty(ref _isAmingWithWeapon, value);
		}

		public ZoomLevelAimEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
