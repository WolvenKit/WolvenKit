using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questItemManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("type")] public CHandle<questIItemManagerNodeType> Type { get; set; }

		public questItemManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
