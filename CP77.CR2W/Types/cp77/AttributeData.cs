using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AttributeData : IDisplayData
	{
		[Ordinal(0)] [RED("label")] public CString Label { get; set; }
		[Ordinal(1)] [RED("icon")] public CString Icon { get; set; }
		[Ordinal(2)] [RED("id")] public TweakDBID Id { get; set; }
		[Ordinal(3)] [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(4)] [RED("maxValue")] public CInt32 MaxValue { get; set; }
		[Ordinal(5)] [RED("description")] public CString Description { get; set; }
		[Ordinal(6)] [RED("availableToUpgrade")] public CBool AvailableToUpgrade { get; set; }
		[Ordinal(7)] [RED("type")] public CEnum<gamedataStatType> Type { get; set; }

		public AttributeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
