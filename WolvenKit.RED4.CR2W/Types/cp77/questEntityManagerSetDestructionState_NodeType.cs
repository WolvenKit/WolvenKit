using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetDestructionState_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] [RED("action")] public CEnum<questSetDestructionStateAction> Action { get; set; }
		[Ordinal(1)] [RED("params")] public CArray<questEntityManagerSetDestructionState_NodeTypeParams> Params { get; set; }

		public questEntityManagerSetDestructionState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
