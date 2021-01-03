using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CityLightSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("forcedStateSource")] public CName ForcedStateSource { get; set; }
		[Ordinal(1)]  [RED("forcedStatesStack")] public CArray<ForcedStateData> ForcedStatesStack { get; set; }
		[Ordinal(2)]  [RED("fuses")] public CArray<FuseData> Fuses { get; set; }
		[Ordinal(3)]  [RED("resetLisenerID")] public CName ResetLisenerID { get; set; }
		[Ordinal(4)]  [RED("state")] public CEnum<ECLSForcedState> State { get; set; }
		[Ordinal(5)]  [RED("timeSystemCallbacks")] public CArray<CHandle<TimetableCallbackData>> TimeSystemCallbacks { get; set; }
		[Ordinal(6)]  [RED("turnOffLisenerID")] public CName TurnOffLisenerID { get; set; }
		[Ordinal(7)]  [RED("turnOnLisenerID")] public CName TurnOnLisenerID { get; set; }
		[Ordinal(8)]  [RED("weatherCallbackId")] public CUInt32 WeatherCallbackId { get; set; }
		[Ordinal(9)]  [RED("weatherListener")] public CHandle<CLSWeatherListener> WeatherListener { get; set; }

		public CityLightSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
