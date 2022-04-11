using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_BenchmarkResults : MenuScenario_BaseMenu
	{
		[Ordinal(4)] 
		[RED("callbackData")] 
		public CHandle<inkCallbackConnectorData> CallbackData
		{
			get => GetPropertyValue<CHandle<inkCallbackConnectorData>>();
			set => SetPropertyValue<CHandle<inkCallbackConnectorData>>(value);
		}
	}
}
