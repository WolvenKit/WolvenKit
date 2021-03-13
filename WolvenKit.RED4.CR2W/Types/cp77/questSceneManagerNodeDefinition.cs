using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("type")] public CHandle<questISceneManagerNodeType> Type { get; set; }

		public questSceneManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
