using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationAttributeData : IScriptable
	{
		[Ordinal(0)] [RED("label")] public CString Label { get; set; }
		[Ordinal(1)] [RED("desc")] public CString Desc { get; set; }
		[Ordinal(2)] [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(3)] [RED("attribute")] public CEnum<gamedataStatType> Attribute { get; set; }
		[Ordinal(4)] [RED("icon")] public CName Icon { get; set; }
		[Ordinal(5)] [RED("maxValue")] public CInt32 MaxValue { get; set; }
		[Ordinal(6)] [RED("minValue")] public CInt32 MinValue { get; set; }
		[Ordinal(7)] [RED("maxed")] public CBool Maxed { get; set; }
		[Ordinal(8)] [RED("atMinimum")] public CBool AtMinimum { get; set; }

		public CharacterCreationAttributeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
