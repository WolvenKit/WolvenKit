using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableEnum : LibTreeDefTreeVariable
	{
		[Ordinal(2)] [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }
		[Ordinal(3)] [RED("enumClass")] public CName EnumClass { get; set; }
		[Ordinal(4)] [RED("defaultValue")] public CInt64 DefaultValue { get; set; }

		public LibTreeDefTreeVariableEnum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
