using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEquipItemNodeDefinition : questAICommandNodeBase
	{
		[Ordinal(2)] [RED("entityReference")] public CHandle<questObservableUniversalRef> EntityReference { get; set; }
		[Ordinal(3)] [RED("params")] public CHandle<questEquipItemParams> Params { get; set; }

		public questEquipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
