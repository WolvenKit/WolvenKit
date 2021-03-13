using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_actorsClassNamesCount : IScriptable
	{
		[Ordinal(0)] [RED("className")] public CName ClassName { get; set; }
		[Ordinal(1)] [RED("count")] public CInt32 Count { get; set; }

		public DEBUG_actorsClassNamesCount(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
