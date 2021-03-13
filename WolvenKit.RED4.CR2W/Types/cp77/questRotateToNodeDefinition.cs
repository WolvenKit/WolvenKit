using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRotateToNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(3)] [RED("params")] public CHandle<questRotateToParams> Params { get; set; }

		public questRotateToNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
