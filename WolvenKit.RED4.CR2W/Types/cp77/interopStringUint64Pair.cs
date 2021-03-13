using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopStringUint64Pair : CVariable
	{
		[Ordinal(0)] [RED("string")] public CString String { get; set; }
		[Ordinal(1)] [RED("number")] public CUInt64 Number { get; set; }

		public interopStringUint64Pair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
