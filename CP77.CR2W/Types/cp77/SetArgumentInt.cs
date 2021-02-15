using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetArgumentInt : SetArguments
	{
		[Ordinal(1)] [RED("customVar")] public CInt32 CustomVar { get; set; }

		public SetArgumentInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
