using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableBool : LibTreeDefTreeVariableBoolBase
	{
		[Ordinal(0)]  [RED("defaultValue")] public CBool DefaultValue { get; set; }
		[Ordinal(1)]  [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }

		public LibTreeDefTreeVariableBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
