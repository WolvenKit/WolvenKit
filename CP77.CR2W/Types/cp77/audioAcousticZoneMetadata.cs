using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAcousticZoneMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("priority")] public CInt32 Priority { get; set; }
		[Ordinal(2)] [RED("bleadingDistance")] public CFloat BleadingDistance { get; set; }
		[Ordinal(3)] [RED("eventsOnEnter")] public CArray<CName> EventsOnEnter { get; set; }
		[Ordinal(4)] [RED("eventsOnExit")] public CArray<CName> EventsOnExit { get; set; }
		[Ordinal(5)] [RED("eventsOnActive")] public CArray<CName> EventsOnActive { get; set; }
		[Ordinal(6)] [RED("soundBanks")] public CArray<CName> SoundBanks { get; set; }
		[Ordinal(7)] [RED("parameters")] public CArray<audioAcousticZoneParameterMapItem> Parameters { get; set; }
		[Ordinal(8)] [RED("reverbSettings")] public CName ReverbSettings { get; set; }
		[Ordinal(9)] [RED("voReverbSettings")] public CName VoReverbSettings { get; set; }
		[Ordinal(10)] [RED("footstepMaterialOverride")] public CName FootstepMaterialOverride { get; set; }

		public audioAcousticZoneMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
