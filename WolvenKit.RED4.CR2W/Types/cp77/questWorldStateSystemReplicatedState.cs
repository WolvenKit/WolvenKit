using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questWorldStateSystemReplicatedState : CVariable
	{
		[Ordinal(0)] [RED("nodeVisibilityMapArray")] public CArray<questNodeVisibilityMapArrayElement> NodeVisibilityMapArray { get; set; }
		[Ordinal(1)] [RED("isInMirrorsAreaMapArray")] public CArray<questIsInMirrorsAreaMapArrayElement> IsInMirrorsAreaMapArray { get; set; }
		[Ordinal(2)] [RED("nodeCollisionMapArray")] public CArray<questNodeCollisionMapArrayElement> NodeCollisionMapArray { get; set; }
		[Ordinal(3)] [RED("prefabVariants")] public CArray<questPrefabVariantMapArrayElement> PrefabVariants { get; set; }

		public questWorldStateSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
