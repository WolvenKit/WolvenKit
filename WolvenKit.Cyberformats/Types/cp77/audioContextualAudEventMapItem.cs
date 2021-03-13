using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioContextualAudEventMapItem : audioAudioMetadata
	{
		[Ordinal(1)] [RED("context")] public CName Context { get; set; }
		[Ordinal(2)] [RED("event")] public CName Event { get; set; }

		public audioContextualAudEventMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
