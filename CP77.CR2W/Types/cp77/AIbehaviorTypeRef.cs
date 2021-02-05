using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTypeRef : CVariable
	{
		[Ordinal(0)]  [RED("isSet")] public CBool IsSet { get; set; }
		[Ordinal(1)]  [RED("customType")] public CName CustomType { get; set; }
		[Ordinal(2)]  [RED("enumeratedType")] public CEnum<AIArgumentType> EnumeratedType { get; set; }

		public AIbehaviorTypeRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
