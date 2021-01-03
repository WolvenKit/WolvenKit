using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayStandaloneComment : CVariable
	{
		[Ordinal(0)]  [RED("comment")] public CString Comment { get; set; }
		[Ordinal(1)]  [RED("itemId")] public scnscreenplayItemId ItemId { get; set; }

		public scnscreenplayStandaloneComment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
