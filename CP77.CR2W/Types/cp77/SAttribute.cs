using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SAttribute : CVariable
	{
		[Ordinal(0)] [RED("attributeName")] public CEnum<gamedataStatType> AttributeName { get; set; }
		[Ordinal(1)] [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(2)] [RED("id")] public TweakDBID Id { get; set; }

		public SAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
