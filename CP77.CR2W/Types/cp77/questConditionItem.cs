using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questConditionItem : CVariable
	{
		[Ordinal(0)]  [RED("socketId")] public CUInt32 SocketId { get; set; }
		[Ordinal(1)]  [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }

		public questConditionItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
