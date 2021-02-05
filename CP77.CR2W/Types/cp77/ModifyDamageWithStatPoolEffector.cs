using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithStatPoolEffector : ModifyDamageEffector
	{
		[Ordinal(0)]  [RED("operationType")] public CEnum<EMathOperator> OperationType { get; set; }
		[Ordinal(1)]  [RED("value")] public CFloat Value { get; set; }
		[Ordinal(2)]  [RED("statPool")] public CEnum<gamedataStatPoolType> StatPool { get; set; }
		[Ordinal(3)]  [RED("poolStatus")] public CString PoolStatus { get; set; }
		[Ordinal(4)]  [RED("maxDmg")] public CFloat MaxDmg { get; set; }
		[Ordinal(5)]  [RED("refObj")] public CString RefObj { get; set; }

		public ModifyDamageWithStatPoolEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
