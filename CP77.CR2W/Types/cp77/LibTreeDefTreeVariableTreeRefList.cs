using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableTreeRefList : LibTreeDefTreeVariable
	{
		[Ordinal(0)]  [RED("defaultValue")] public CArray<CHandle<LibTreeCTreeReference>> DefaultValue { get; set; }
		[Ordinal(1)]  [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }

		public LibTreeDefTreeVariableTreeRefList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
