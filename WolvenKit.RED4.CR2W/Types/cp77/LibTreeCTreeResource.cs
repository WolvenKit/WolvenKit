using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeCTreeResource : CResource
	{
		[Ordinal(1)] [RED("variables")] public LibTreeDefTreeVariablesList Variables { get; set; }

		public LibTreeCTreeResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
