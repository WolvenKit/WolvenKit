using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class locVoiceoverLengthMap : ISerializable
	{
		[Ordinal(0)]  [RED("entries")] public CArray<locVoLengthEntry> Entries { get; set; }

		public locVoiceoverLengthMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
