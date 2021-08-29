using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DataTermDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Variant _fastTravelPoint;
		private gamebbScriptID_Bool _triggerWorldMap;

		[Ordinal(7)] 
		[RED("fastTravelPoint")] 
		public gamebbScriptID_Variant FastTravelPoint
		{
			get => GetProperty(ref _fastTravelPoint);
			set => SetProperty(ref _fastTravelPoint, value);
		}

		[Ordinal(8)] 
		[RED("triggerWorldMap")] 
		public gamebbScriptID_Bool TriggerWorldMap
		{
			get => GetProperty(ref _triggerWorldMap);
			set => SetProperty(ref _triggerWorldMap, value);
		}
	}
}
