using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaption : CVariable
	{
		[Ordinal(0)] [RED("parts")] public CArray<CHandle<gameinteractionsChoiceCaptionPart>> Parts { get; set; }

		public gameinteractionsChoiceCaption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
