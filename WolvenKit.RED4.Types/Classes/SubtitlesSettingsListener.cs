using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SubtitlesSettingsListener : userSettingsVarListener
	{
		private CWeakHandle<BaseSubtitlesGameController> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<BaseSubtitlesGameController> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}
	}
}
