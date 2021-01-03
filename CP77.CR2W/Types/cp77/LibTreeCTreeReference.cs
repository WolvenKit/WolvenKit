using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LibTreeCTreeReference : ISerializable
	{
		[Ordinal(0)]  [RED("TreeDefinition")] public rRef<LibTreeCTreeResource> TreeDefinition { get; set; }
		[Ordinal(1)]  [RED("parameters")] public LibTreeParameterList Parameters { get; set; }

		public LibTreeCTreeReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
