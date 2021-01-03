using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaption : CVariable
	{
		[Ordinal(0)]  [RED("parts")] public CArray<CHandle<gameinteractionsChoiceCaptionPart>> Parts { get; set; }

		public gameinteractionsChoiceCaption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
