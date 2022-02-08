using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OxygenListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("oxygenBar")] 
		public CWeakHandle<OxygenbarWidgetGameController> OxygenBar
		{
			get => GetPropertyValue<CWeakHandle<OxygenbarWidgetGameController>>();
			set => SetPropertyValue<CWeakHandle<OxygenbarWidgetGameController>>(value);
		}
	}
}
