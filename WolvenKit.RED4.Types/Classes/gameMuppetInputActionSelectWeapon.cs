using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputActionSelectWeapon : gameIMuppetInputAction
	{
		[Ordinal(0)] 
		[RED("wantedWeapon")] 
		public gameItemID WantedWeapon
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public gameMuppetInputActionSelectWeapon()
		{
			WantedWeapon = new();
		}
	}
}
