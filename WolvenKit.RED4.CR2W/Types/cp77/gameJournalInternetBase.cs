using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetBase : IScriptable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("linkAddress")] public CString LinkAddress { get; set; }
		[Ordinal(2)] [RED("tintColor")] public CColor TintColor { get; set; }
		[Ordinal(3)] [RED("hoverTintColor")] public CColor HoverTintColor { get; set; }

		public gameJournalInternetBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
