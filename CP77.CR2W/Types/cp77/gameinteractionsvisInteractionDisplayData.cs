using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisInteractionDisplayData : CVariable
	{
		[Ordinal(0)]  [RED("HoldAction")] public CBool HoldAction { get; set; }
		[Ordinal(1)]  [RED("calizedName")] public CString CalizedName { get; set; }
		[Ordinal(2)]  [RED("oice")] public gameinteractionsChoice Oice { get; set; }
		[Ordinal(3)]  [RED("pe")] public gameinteractionsChoiceTypeWrapper Pe { get; set; }
		[Ordinal(4)]  [RED("putAction")] public CName PutAction { get; set; }
		[Ordinal(5)]  [RED("wInputKey")] public CEnum<EInputKey> WInputKey { get; set; }

		public gameinteractionsvisInteractionDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
