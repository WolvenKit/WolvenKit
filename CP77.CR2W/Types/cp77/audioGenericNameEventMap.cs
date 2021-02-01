using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioGenericNameEventMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("eventOverrides")] public CHandle<audioGenericNameEventDictionary> EventOverrides { get; set; }

		public audioGenericNameEventMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
