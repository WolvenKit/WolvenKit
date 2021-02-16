using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioContextualAudEventMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("contextualAudEventMapItems")] public CArray<audioContextualAudEventMapItem> ContextualAudEventMapItems { get; set; }

		public audioContextualAudEventMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
