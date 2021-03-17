using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTermDeviceBlackboardDef : DeviceBaseBlackboardDef
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

		public DataTermDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
