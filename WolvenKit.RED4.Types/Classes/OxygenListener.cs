using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OxygenListener : gameScriptStatPoolsListener
	{
		private CWeakHandle<OxygenbarWidgetGameController> _oxygenBar;

		[Ordinal(0)] 
		[RED("oxygenBar")] 
		public CWeakHandle<OxygenbarWidgetGameController> OxygenBar
		{
			get => GetProperty(ref _oxygenBar);
			set => SetProperty(ref _oxygenBar, value);
		}
	}
}
