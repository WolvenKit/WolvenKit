using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimapPOIMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] [RED("pulseWidget")] public inkWidgetReference PulseWidget { get; set; }
		[Ordinal(15)] [RED("pingAnimationOnStateChange")] public CBool PingAnimationOnStateChange { get; set; }
		[Ordinal(16)] [RED("poiMappin")] public wCHandle<gamemappinsPointOfInterestMappin> PoiMappin { get; set; }
		[Ordinal(17)] [RED("isCompletedPhase")] public CBool IsCompletedPhase { get; set; }
		[Ordinal(18)] [RED("mappinPhase")] public CEnum<gamedataMappinPhase> MappinPhase { get; set; }
		[Ordinal(19)] [RED("pingAnim")] public CHandle<inkanimProxy> PingAnim { get; set; }
		[Ordinal(20)] [RED("c_pingAnimCount")] public CUInt32 C_pingAnimCount { get; set; }
		[Ordinal(21)] [RED("vehicleMinimapMappinComponent")] public CHandle<VehicleMinimapMappinComponent> VehicleMinimapMappinComponent { get; set; }
		[Ordinal(22)] [RED("keepIconOnClamping")] public CBool KeepIconOnClamping { get; set; }

		public MinimapPOIMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
