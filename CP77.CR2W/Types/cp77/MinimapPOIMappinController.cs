using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinimapPOIMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(7)]  [RED("pulseWidget")] public inkWidgetReference PulseWidget { get; set; }
		[Ordinal(8)]  [RED("pingAnimationOnStateChange")] public CBool PingAnimationOnStateChange { get; set; }
		[Ordinal(9)]  [RED("poiMappin")] public wCHandle<gamemappinsPointOfInterestMappin> PoiMappin { get; set; }
		[Ordinal(10)]  [RED("isCompletedPhase")] public CBool IsCompletedPhase { get; set; }
		[Ordinal(11)]  [RED("mappinPhase")] public CEnum<gamedataMappinPhase> MappinPhase { get; set; }
		[Ordinal(12)]  [RED("pingAnim")] public CHandle<inkanimProxy> PingAnim { get; set; }
		[Ordinal(13)]  [RED("c_pingAnimCount")] public CUInt32 C_pingAnimCount { get; set; }
		[Ordinal(14)]  [RED("vehicleMinimapMappinComponent")] public CHandle<VehicleMinimapMappinComponent> VehicleMinimapMappinComponent { get; set; }
		[Ordinal(15)]  [RED("keepIconOnClamping")] public CBool KeepIconOnClamping { get; set; }

		public MinimapPOIMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
