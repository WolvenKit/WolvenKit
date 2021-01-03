using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("definitionResource")] public rRef<gameinteractionsInteractionDescriptorResource> DefinitionResource { get; set; }
		[Ordinal(1)]  [RED("interactionRootOffset")] public Vector3 InteractionRootOffset { get; set; }
		[Ordinal(2)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)]  [RED("layerOverrides")] public CArray<gameinteractionsInteractionDefinitionOverrider> LayerOverrides { get; set; }
		[Ordinal(4)]  [RED("layerOverridesTemp")] public CArray<gameinteractionsInteractionDefinitionOverrider> LayerOverridesTemp { get; set; }

		public gameinteractionsComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
