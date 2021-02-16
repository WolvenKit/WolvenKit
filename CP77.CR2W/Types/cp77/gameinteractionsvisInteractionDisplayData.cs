using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisInteractionDisplayData : CVariable
	{
		[Ordinal(0)] [RED("putAction")] public CName PutAction { get; set; }
		[Ordinal(1)] [RED("wInputKey")] public CEnum<EInputKey> WInputKey { get; set; }
		[Ordinal(2)] [RED("HoldAction")] public CBool HoldAction { get; set; }
		[Ordinal(3)] [RED("calizedName")] public CString CalizedName { get; set; }
		[Ordinal(4)] [RED("pe")] public gameinteractionsChoiceTypeWrapper Pe { get; set; }
		[Ordinal(5)] [RED("oice")] public gameinteractionsChoice Oice { get; set; }

		public gameinteractionsvisInteractionDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
