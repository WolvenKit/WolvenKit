using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioGroupingTagMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("shape")] public CName Shape { get; set; }
		[Ordinal(2)] [RED("classificationMethod")] public CEnum<audioClassificationMethod> ClassificationMethod { get; set; }
		[Ordinal(3)] [RED("inputEmitterName")] public CName InputEmitterName { get; set; }
		[Ordinal(4)] [RED("inputEventNames")] public CArray<CName> InputEventNames { get; set; }
		[Ordinal(5)] [RED("inputTags")] public CArray<CName> InputTags { get; set; }
		[Ordinal(6)] [RED("outputEventId")] public CName OutputEventId { get; set; }
		[Ordinal(7)] [RED("minimalGroupCount")] public CFloat MinimalGroupCount { get; set; }
		[Ordinal(8)] [RED("fullGroupCount")] public CFloat FullGroupCount { get; set; }

		public audioGroupingTagMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
