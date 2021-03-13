using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CityLightSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("timeSystemCallbacks")] public CArray<CHandle<TimetableCallbackData>> TimeSystemCallbacks { get; set; }
		[Ordinal(1)] [RED("fuses")] public CArray<FuseData> Fuses { get; set; }
		[Ordinal(2)] [RED("state")] public CEnum<ECLSForcedState> State { get; set; }
		[Ordinal(3)] [RED("forcedStateSource")] public CName ForcedStateSource { get; set; }
		[Ordinal(4)] [RED("forcedStatesStack")] public CArray<ForcedStateData> ForcedStatesStack { get; set; }
		[Ordinal(5)] [RED("weatherListener")] public CHandle<CLSWeatherListener> WeatherListener { get; set; }
		[Ordinal(6)] [RED("turnOffLisenerID")] public CName TurnOffLisenerID { get; set; }
		[Ordinal(7)] [RED("turnOnLisenerID")] public CName TurnOnLisenerID { get; set; }
		[Ordinal(8)] [RED("resetLisenerID")] public CName ResetLisenerID { get; set; }
		[Ordinal(9)] [RED("weatherCallbackId")] public CUInt32 WeatherCallbackId { get; set; }

		public CityLightSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
