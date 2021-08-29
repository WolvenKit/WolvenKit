using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HDRSettingsVarListener : userSettingsVarListener
	{
		private CWeakHandle<gameuiHDRSettingsGameController> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<gameuiHDRSettingsGameController> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}
	}
}
