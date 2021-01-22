using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessageMenuAttachmentData : IScriptable
	{
		[Ordinal(0)]  [RED("entryHash")] public CInt32 EntryHash { get; set; }

		public MessageMenuAttachmentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
