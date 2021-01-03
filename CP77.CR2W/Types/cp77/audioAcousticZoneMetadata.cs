using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAcousticZoneMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("bleadingDistance")] public CFloat BleadingDistance { get; set; }
		[Ordinal(1)]  [RED("eventsOnActive")] public CArray<CName> EventsOnActive { get; set; }
		[Ordinal(2)]  [RED("eventsOnEnter")] public CArray<CName> EventsOnEnter { get; set; }
		[Ordinal(3)]  [RED("eventsOnExit")] public CArray<CName> EventsOnExit { get; set; }
		[Ordinal(4)]  [RED("footstepMaterialOverride")] public CName FootstepMaterialOverride { get; set; }
		[Ordinal(5)]  [RED("parameters")] public CArray<audioAcousticZoneParameterMapItem> Parameters { get; set; }
		[Ordinal(6)]  [RED("priority")] public CInt32 Priority { get; set; }
		[Ordinal(7)]  [RED("reverbSettings")] public CName ReverbSettings { get; set; }
		[Ordinal(8)]  [RED("soundBanks")] public CArray<CName> SoundBanks { get; set; }
		[Ordinal(9)]  [RED("voReverbSettings")] public CName VoReverbSettings { get; set; }

		public audioAcousticZoneMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
