using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questScene_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(1)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }

		public questScene_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
