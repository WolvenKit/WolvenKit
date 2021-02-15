using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entReplicatedInputSetters : CVariable
	{
		[Ordinal(0)] [RED("serverReplicatedTime")] public netTime ServerReplicatedTime { get; set; }

		public entReplicatedInputSetters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
