using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRenderFxManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("type")] public CHandle<questIRenderFxManagerNodeType> Type { get; set; }

		public questRenderFxManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
