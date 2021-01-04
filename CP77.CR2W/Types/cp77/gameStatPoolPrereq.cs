using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatPoolPrereq : gameIComparisonPrereq
	{
		[Ordinal(0)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(1)]  [RED("valueToCheck")] public CFloat ValueToCheck { get; set; }

		public gameStatPoolPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
