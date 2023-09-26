using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedHotkeyItemStatListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("hotkeyController")] 
		public CWeakHandle<ChargedHotkeyItemBaseController> HotkeyController
		{
			get => GetPropertyValue<CWeakHandle<ChargedHotkeyItemBaseController>>();
			set => SetPropertyValue<CWeakHandle<ChargedHotkeyItemBaseController>>(value);
		}

		public ChargedHotkeyItemStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
