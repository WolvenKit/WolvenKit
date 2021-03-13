using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDebugPath : CVariable
	{
		[Ordinal(0)] [RED("str")] public CString Str { get; set; }

		public gameDebugPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
