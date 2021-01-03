using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("EmitterDecorator")] public CName EmitterDecorator { get; set; }
		[Ordinal(1)]  [RED("EventsOnActive")] public CArray<audioAudEventStruct> EventsOnActive { get; set; }
		[Ordinal(2)]  [RED("EventsOnEnter")] public CArray<audioAudEventStruct> EventsOnEnter { get; set; }
		[Ordinal(3)]  [RED("EventsOnExit")] public CArray<audioAudEventStruct> EventsOnExit { get; set; }
		[Ordinal(4)]  [RED("FootstepMaterialOverride")] public CName FootstepMaterialOverride { get; set; }
		[Ordinal(5)]  [RED("MetadataParent")] public CName MetadataParent { get; set; }
		[Ordinal(6)]  [RED("Parameters")] public CArray<audioAudParameter> Parameters { get; set; }
		[Ordinal(7)]  [RED("Priority")] public CInt32 Priority { get; set; }
		[Ordinal(8)]  [RED("Reverb")] public CName Reverb { get; set; }
		[Ordinal(9)]  [RED("SoundBanks")] public CArray<audioSoundBankStruct> SoundBanks { get; set; }
		[Ordinal(10)]  [RED("Switches")] public CArray<audioAudSwitch> Switches { get; set; }
		[Ordinal(11)]  [RED("VoReverb")] public CName VoReverb { get; set; }
		[Ordinal(12)]  [RED("ambientPaletteEntries")] public CArray<audioAmbientPaletteEntry> AmbientPaletteEntries { get; set; }
		[Ordinal(13)]  [RED("eventOverrides")] public CName EventOverrides { get; set; }
		[Ordinal(14)]  [RED("groupingSettings")] public audioAmbientAreaGroupingSettings GroupingSettings { get; set; }
		[Ordinal(15)]  [RED("insideSourceDistance")] public CFloat InsideSourceDistance { get; set; }
		[Ordinal(16)]  [RED("isMusic")] public CBool IsMusic { get; set; }
		[Ordinal(17)]  [RED("mergeRoomsWithinArea")] public CBool MergeRoomsWithinArea { get; set; }
		[Ordinal(18)]  [RED("mixingContext")] public CName MixingContext { get; set; }
		[Ordinal(19)]  [RED("outdoorness")] public CFloat Outdoorness { get; set; }
		[Ordinal(20)]  [RED("outdoornessOverride")] public CBool OutdoornessOverride { get; set; }
		[Ordinal(21)]  [RED("outerDistance")] public CFloat OuterDistance { get; set; }
		[Ordinal(22)]  [RED("quadSettings")] public audioQuadEmitterSettings QuadSettings { get; set; }
		[Ordinal(23)]  [RED("reverbTransitionTime")] public CFloat ReverbTransitionTime { get; set; }
		[Ordinal(24)]  [RED("verticalOuterDistance")] public CFloat VerticalOuterDistance { get; set; }

		public audioAmbientAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
