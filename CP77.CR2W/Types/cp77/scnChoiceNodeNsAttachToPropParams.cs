using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAttachToPropParams : CVariable
	{
		[Ordinal(0)] [RED("propId")] public scnPropId PropId { get; set; }
		[Ordinal(1)] [RED("visualizerStyle")] public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle { get; set; }

		public scnChoiceNodeNsAttachToPropParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
