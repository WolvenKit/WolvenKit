using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaptionStringPart : gameinteractionsChoiceCaptionPart
	{
		[Ordinal(0)] [RED("content")] public CString Content { get; set; }

		public gameinteractionsChoiceCaptionStringPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
