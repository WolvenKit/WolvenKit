using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerManageBinkComponent_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] [RED("params")] public CArray<questEntityManagerManageBinkComponent_NodeTypeParams> Params { get; set; }

		public questEntityManagerManageBinkComponent_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
