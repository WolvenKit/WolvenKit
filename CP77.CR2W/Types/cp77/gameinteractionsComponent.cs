using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("definitionResource")] public rRef<gameinteractionsInteractionDescriptorResource> DefinitionResource { get; set; }
		[Ordinal(6)] [RED("interactionRootOffset")] public Vector3 InteractionRootOffset { get; set; }
		[Ordinal(7)] [RED("layerOverrides")] public CArray<gameinteractionsInteractionDefinitionOverrider> LayerOverrides { get; set; }
		[Ordinal(8)] [RED("layerOverridesTemp")] public CArray<gameinteractionsInteractionDefinitionOverrider> LayerOverridesTemp { get; set; }
		[Ordinal(9)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public gameinteractionsComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
