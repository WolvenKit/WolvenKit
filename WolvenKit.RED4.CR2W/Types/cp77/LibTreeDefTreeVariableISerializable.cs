using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableISerializable : LibTreeDefTreeVariable
	{
		[Ordinal(2)] [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }

		public LibTreeDefTreeVariableISerializable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
