using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NumberPlateSelector : LCDScreenSelector
	{
		[Ordinal(0)]  [RED("customMessageID")] public TweakDBID CustomMessageID { get; set; }
		[Ordinal(1)]  [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }
		[Ordinal(2)]  [RED("customNumber")] public CInt32 CustomNumber { get; set; }
		[Ordinal(3)]  [RED("recordID")] public TweakDBID RecordID { get; set; }

		public NumberPlateSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
