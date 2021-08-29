using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PersistentDotSettingsListener : userSettingsVarListener
	{
		private CWeakHandle<CrosshairGameControllerPersistentDot> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<CrosshairGameControllerPersistentDot> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}
	}
}
