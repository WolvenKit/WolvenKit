using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessengerContactSyncData : IScriptable
	{
		[Ordinal(0)]  [RED("type")] public CEnum<MessengerContactType> Type { get; set; }
		[Ordinal(1)]  [RED("entryHash")] public CInt32 EntryHash { get; set; }
		[Ordinal(2)]  [RED("level")] public CInt32 Level { get; set; }

		public MessengerContactSyncData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
