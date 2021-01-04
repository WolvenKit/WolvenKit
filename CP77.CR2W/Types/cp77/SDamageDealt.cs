using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SDamageDealt : CVariable
	{
		[Ordinal(0)]  [RED("affectedStatPool")] public CEnum<gamedataStatPoolType> AffectedStatPool { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<gamedataDamageType> Type { get; set; }
		[Ordinal(2)]  [RED("value")] public CFloat Value { get; set; }

		public SDamageDealt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
