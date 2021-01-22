using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animStackTracksExtender_JsonProperties : ISerializable
	{
		[Ordinal(0)]  [RED("entries")] public CArray<animStackTracksExtender_JsonEntry> Entries { get; set; }

		public animStackTracksExtender_JsonProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
