using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAcousticConstantsPreset : audioAudioMetadata
	{
		[Ordinal(1)] [RED("dopplerFactor")] public CFloat DopplerFactor { get; set; }
		[Ordinal(2)] [RED("speedOfSound")] public CFloat SpeedOfSound { get; set; }
		[Ordinal(3)] [RED("wideInteriorLimit")] public CFloat WideInteriorLimit { get; set; }
		[Ordinal(4)] [RED("enclosedCeilingDistance")] public CFloat EnclosedCeilingDistance { get; set; }
		[Ordinal(5)] [RED("urbanNarrowDistance")] public CFloat UrbanNarrowDistance { get; set; }
		[Ordinal(6)] [RED("urbanStreetDistance")] public CFloat UrbanStreetDistance { get; set; }
		[Ordinal(7)] [RED("exteriorWideAltitude")] public CFloat ExteriorWideAltitude { get; set; }
		[Ordinal(8)] [RED("elevatedOpenDistance")] public CFloat ElevatedOpenDistance { get; set; }
		[Ordinal(9)] [RED("ambExteriorCeilingMinDistance")] public CFloat AmbExteriorCeilingMinDistance { get; set; }
		[Ordinal(10)] [RED("ambExteriorCeilingMaxDistance")] public CFloat AmbExteriorCeilingMaxDistance { get; set; }
		[Ordinal(11)] [RED("badlandsWideRelativeAltitude")] public CFloat BadlandsWideRelativeAltitude { get; set; }
		[Ordinal(12)] [RED("repositioningStandardZoomFactor")] public CFloat RepositioningStandardZoomFactor { get; set; }
		[Ordinal(13)] [RED("repositioningScanningZoomFactor")] public CFloat RepositioningScanningZoomFactor { get; set; }
		[Ordinal(14)] [RED("repositioningVoStandardZoomFactor")] public CFloat RepositioningVoStandardZoomFactor { get; set; }
		[Ordinal(15)] [RED("repositioningVoScanningZoomFactor")] public CFloat RepositioningVoScanningZoomFactor { get; set; }
		[Ordinal(16)] [RED("groupingExcludedVisualTags")] public CArray<CName> GroupingExcludedVisualTags { get; set; }
		[Ordinal(17)] [RED("windowEventName")] public CName WindowEventName { get; set; }
		[Ordinal(18)] [RED("maxWindowOffset")] public CFloat MaxWindowOffset { get; set; }

		public audioAcousticConstantsPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
