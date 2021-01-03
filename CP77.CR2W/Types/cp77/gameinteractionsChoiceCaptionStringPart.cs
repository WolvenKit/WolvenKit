using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaptionStringPart : gameinteractionsChoiceCaptionPart
	{
		[Ordinal(0)]  [RED("content")] public CString Content { get; set; }

		public gameinteractionsChoiceCaptionStringPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
