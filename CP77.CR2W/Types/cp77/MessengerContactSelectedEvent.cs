using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MessengerContactSelectedEvent : redEvent
	{
		[Ordinal(0)]  [RED("entryHash")] public CInt32 EntryHash { get; set; }
		[Ordinal(1)]  [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<MessengerContactType> Type { get; set; }

		public MessengerContactSelectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
