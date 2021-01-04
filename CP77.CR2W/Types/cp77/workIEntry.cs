using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workIEntry : ISerializable
	{
		[Ordinal(0)]  [RED("flags")] public CUInt32 Flags { get; set; }
		[Ordinal(1)]  [RED("id")] public workWorkEntryId Id { get; set; }

		public workIEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
