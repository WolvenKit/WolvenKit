using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioDynamicReverbSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("reverbType")] public CEnum<audioDynamicReverbType> ReverbType { get; set; }
		[Ordinal(2)] [RED("crossover1")] public audioReverbCrossoverParams Crossover1 { get; set; }
		[Ordinal(3)] [RED("crossover2")] public audioReverbCrossoverParams Crossover2 { get; set; }
		[Ordinal(4)] [RED("maxDistance")] public CFloat MaxDistance { get; set; }
		[Ordinal(5)] [RED("smallReverb")] public CName SmallReverb { get; set; }
		[Ordinal(6)] [RED("smallReverbMaxDistance")] public CFloat SmallReverbMaxDistance { get; set; }
		[Ordinal(7)] [RED("smallReverbFadeOutThreshold")] public CFloat SmallReverbFadeOutThreshold { get; set; }
		[Ordinal(8)] [RED("mediumReverb")] public CName MediumReverb { get; set; }
		[Ordinal(9)] [RED("largeReverb")] public CName LargeReverb { get; set; }
		[Ordinal(10)] [RED("vehicleReverb")] public CName VehicleReverb { get; set; }
		[Ordinal(11)] [RED("overrideWeaponTail")] public CBool OverrideWeaponTail { get; set; }
		[Ordinal(12)] [RED("sourceBasedReverbSet")] public CName SourceBasedReverbSet { get; set; }
		[Ordinal(13)] [RED("weaponTailType")] public CEnum<audioWeaponTailEnvironment> WeaponTailType { get; set; }
		[Ordinal(14)] [RED("echoPositionType")] public CEnum<audioEchoPositionType> EchoPositionType { get; set; }
		[Ordinal(15)] [RED("reportPositionType")] public CEnum<audioEchoPositionType> ReportPositionType { get; set; }

		public audioDynamicReverbSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
