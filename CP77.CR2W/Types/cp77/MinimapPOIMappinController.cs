using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinimapPOIMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("c_pingAnimCount")] public CUInt32 C_pingAnimCount { get; set; }
		[Ordinal(1)]  [RED("isCompletedPhase")] public CBool IsCompletedPhase { get; set; }
		[Ordinal(2)]  [RED("keepIconOnClamping")] public CBool KeepIconOnClamping { get; set; }
		[Ordinal(3)]  [RED("mappinPhase")] public CEnum<gamedataMappinPhase> MappinPhase { get; set; }
		[Ordinal(4)]  [RED("pingAnim")] public CHandle<inkanimProxy> PingAnim { get; set; }
		[Ordinal(5)]  [RED("pingAnimationOnStateChange")] public CBool PingAnimationOnStateChange { get; set; }
		[Ordinal(6)]  [RED("poiMappin")] public wCHandle<gamemappinsPointOfInterestMappin> PoiMappin { get; set; }
		[Ordinal(7)]  [RED("pulseWidget")] public inkWidgetReference PulseWidget { get; set; }
		[Ordinal(8)]  [RED("vehicleMinimapMappinComponent")] public CHandle<VehicleMinimapMappinComponent> VehicleMinimapMappinComponent { get; set; }

		public MinimapPOIMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
