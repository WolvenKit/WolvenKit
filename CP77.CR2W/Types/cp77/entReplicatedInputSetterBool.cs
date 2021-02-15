using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entReplicatedInputSetterBool : entReplicatedInputSetterBase
	{
		[Ordinal(2)] [RED("value")] public CBool Value { get; set; }

		public entReplicatedInputSetterBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
