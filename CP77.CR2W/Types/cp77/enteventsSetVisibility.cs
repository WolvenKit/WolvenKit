using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class enteventsSetVisibility : redEvent
	{
		[Ordinal(0)]  [RED("source")] public CEnum<entVisibilityParamSource> Source { get; set; }
		[Ordinal(1)]  [RED("visible")] public CBool Visible { get; set; }

		public enteventsSetVisibility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
