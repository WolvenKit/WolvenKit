using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestListHeaderData : IScriptable
	{
		[Ordinal(0)]  [RED("type")] public CInt32 Type { get; set; }
		[Ordinal(1)]  [RED("nameLocKey")] public CName NameLocKey { get; set; }

		public QuestListHeaderData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
