using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeResourcePoolListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("meleeCrosshair")] 
		public CWeakHandle<CrosshairGameController_Melee> MeleeCrosshair
		{
			get => GetPropertyValue<CWeakHandle<CrosshairGameController_Melee>>();
			set => SetPropertyValue<CWeakHandle<CrosshairGameController_Melee>>(value);
		}
	}
}
