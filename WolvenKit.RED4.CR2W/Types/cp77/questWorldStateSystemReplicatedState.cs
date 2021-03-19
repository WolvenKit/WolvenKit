using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questWorldStateSystemReplicatedState : CVariable
	{
		private CArray<questNodeVisibilityMapArrayElement> _nodeVisibilityMapArray;
		private CArray<questIsInMirrorsAreaMapArrayElement> _isInMirrorsAreaMapArray;
		private CArray<questNodeCollisionMapArrayElement> _nodeCollisionMapArray;
		private CArray<questPrefabVariantMapArrayElement> _prefabVariants;

		[Ordinal(0)] 
		[RED("nodeVisibilityMapArray")] 
		public CArray<questNodeVisibilityMapArrayElement> NodeVisibilityMapArray
		{
			get => GetProperty(ref _nodeVisibilityMapArray);
			set => SetProperty(ref _nodeVisibilityMapArray, value);
		}

		[Ordinal(1)] 
		[RED("isInMirrorsAreaMapArray")] 
		public CArray<questIsInMirrorsAreaMapArrayElement> IsInMirrorsAreaMapArray
		{
			get => GetProperty(ref _isInMirrorsAreaMapArray);
			set => SetProperty(ref _isInMirrorsAreaMapArray, value);
		}

		[Ordinal(2)] 
		[RED("nodeCollisionMapArray")] 
		public CArray<questNodeCollisionMapArrayElement> NodeCollisionMapArray
		{
			get => GetProperty(ref _nodeCollisionMapArray);
			set => SetProperty(ref _nodeCollisionMapArray, value);
		}

		[Ordinal(3)] 
		[RED("prefabVariants")] 
		public CArray<questPrefabVariantMapArrayElement> PrefabVariants
		{
			get => GetProperty(ref _prefabVariants);
			set => SetProperty(ref _prefabVariants, value);
		}

		public questWorldStateSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
