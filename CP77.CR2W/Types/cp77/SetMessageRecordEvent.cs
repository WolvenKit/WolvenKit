using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetMessageRecordEvent : redEvent
	{
		[Ordinal(0)]  [RED("customNumber")] public CInt32 CustomNumber { get; set; }
		[Ordinal(1)]  [RED("messageRecordID")] public TweakDBID MessageRecordID { get; set; }
		[Ordinal(2)]  [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }

		public SetMessageRecordEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
