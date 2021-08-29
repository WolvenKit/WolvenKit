using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoomLevelAimEvents : ZoomEventsTransition
	{
		private CBool _isAmingWithWeapon;

		[Ordinal(0)] 
		[RED("isAmingWithWeapon")] 
		public CBool IsAmingWithWeapon
		{
			get => GetProperty(ref _isAmingWithWeapon);
			set => SetProperty(ref _isAmingWithWeapon, value);
		}
	}
}
