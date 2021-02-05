using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioReflectionEmitterSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("reflectionEvent")] public CName ReflectionEvent { get; set; }
		[Ordinal(1)]  [RED("fadeout")] public CFloat Fadeout { get; set; }
		[Ordinal(2)]  [RED("reflectionDeltaThreshold")] public CFloat ReflectionDeltaThreshold { get; set; }
		[Ordinal(3)]  [RED("maxConcurrentReflections")] public CUInt32 MaxConcurrentReflections { get; set; }
		[Ordinal(4)]  [RED("broadcastChannel")] public CUInt32 BroadcastChannel { get; set; }
		[Ordinal(5)]  [RED("listenerRelativePosition")] public CBool ListenerRelativePosition { get; set; }
		[Ordinal(6)]  [RED("upReflectionEnabled")] public CBool UpReflectionEnabled { get; set; }
		[Ordinal(7)]  [RED("shortReflectionIndoors")] public CBool ShortReflectionIndoors { get; set; }
		[Ordinal(8)]  [RED("reflectionVariant")] public CEnum<audioReflectionVariant> ReflectionVariant { get; set; }
		[Ordinal(9)]  [RED("backReflectionCutoffSpread")] public CFloat BackReflectionCutoffSpread { get; set; }
		[Ordinal(10)]  [RED("backReflectionCutoffStrength")] public CFloat BackReflectionCutoffStrength { get; set; }
		[Ordinal(11)]  [RED("backReflectionCutoffSoftness")] public CFloat BackReflectionCutoffSoftness { get; set; }
		[Ordinal(12)]  [RED("farReflectionDistance")] public CFloat FarReflectionDistance { get; set; }
		[Ordinal(13)]  [RED("nearReflectionDistance")] public CFloat NearReflectionDistance { get; set; }
		[Ordinal(14)]  [RED("minimumFaceAlignement")] public CFloat MinimumFaceAlignement { get; set; }
		[Ordinal(15)]  [RED("fixedRaycastPitch")] public CFloat FixedRaycastPitch { get; set; }

		public audioReflectionEmitterSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
