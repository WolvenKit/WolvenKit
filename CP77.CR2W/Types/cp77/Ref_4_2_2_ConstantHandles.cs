using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_4_2_2_ConstantHandles : IScriptable
	{
		[Ordinal(0)]  [RED("i")] public CInt32 I { get; set; }
		[Ordinal(1)]  [RED("f")] public CFloat F { get; set; }
		[Ordinal(2)]  [RED("s")] public CHandle<IScriptable> S { get; set; }

		public Ref_4_2_2_ConstantHandles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
