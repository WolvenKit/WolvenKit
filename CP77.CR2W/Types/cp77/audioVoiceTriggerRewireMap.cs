using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerRewireMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("includes")] public CArray<CName> Includes { get; set; }
		[Ordinal(2)] [RED("items")] public CArray<audioVoiceTriggerRewireMapItem> Items { get; set; }

		public audioVoiceTriggerRewireMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
