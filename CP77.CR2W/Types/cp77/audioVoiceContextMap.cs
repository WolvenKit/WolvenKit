using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVoiceContextMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("contexts")] public CArray<audioVoiceContextMapItem> Contexts { get; set; }
		[Ordinal(1)]  [RED("includes")] public CArray<CName> Includes { get; set; }

		public audioVoiceContextMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
