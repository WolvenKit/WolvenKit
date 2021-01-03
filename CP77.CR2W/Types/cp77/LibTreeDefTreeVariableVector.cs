using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableVector : LibTreeDefTreeVariable
	{
		[Ordinal(0)]  [RED("defaultValue")] public Vector3 DefaultValue { get; set; }
		[Ordinal(1)]  [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }

		public LibTreeDefTreeVariableVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
