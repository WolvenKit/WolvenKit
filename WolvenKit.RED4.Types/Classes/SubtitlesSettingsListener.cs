using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SubtitlesSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<BaseSubtitlesGameController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<BaseSubtitlesGameController>>();
			set => SetPropertyValue<CWeakHandle<BaseSubtitlesGameController>>(value);
		}
	}
}
