using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeResourcePoolListener : gameScriptStatPoolsListener
	{
		private CWeakHandle<CrosshairGameController_Melee> _meleeCrosshair;

		[Ordinal(0)] 
		[RED("meleeCrosshair")] 
		public CWeakHandle<CrosshairGameController_Melee> MeleeCrosshair
		{
			get => GetProperty(ref _meleeCrosshair);
			set => SetProperty(ref _meleeCrosshair, value);
		}
	}
}
