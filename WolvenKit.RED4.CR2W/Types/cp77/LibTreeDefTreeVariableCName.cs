using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableCName : LibTreeDefTreeVariable
	{
		[Ordinal(2)] [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }
		[Ordinal(3)] [RED("defaultValue")] public CName DefaultValue { get; set; }

		public LibTreeDefTreeVariableCName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
