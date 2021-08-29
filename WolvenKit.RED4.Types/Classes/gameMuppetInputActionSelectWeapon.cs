using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputActionSelectWeapon : gameIMuppetInputAction
	{
		private gameItemID _wantedWeapon;

		[Ordinal(0)] 
		[RED("wantedWeapon")] 
		public gameItemID WantedWeapon
		{
			get => GetProperty(ref _wantedWeapon);
			set => SetProperty(ref _wantedWeapon, value);
		}
	}
}
