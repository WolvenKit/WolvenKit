using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PersistentDotSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<CrosshairGameControllerPersistentDot> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<CrosshairGameControllerPersistentDot>>();
			set => SetPropertyValue<CWeakHandle<CrosshairGameControllerPersistentDot>>(value);
		}
	}
}
