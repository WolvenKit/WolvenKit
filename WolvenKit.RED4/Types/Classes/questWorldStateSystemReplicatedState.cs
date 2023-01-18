using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questWorldStateSystemReplicatedState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeVisibilityMapArray")] 
		public CArray<questNodeVisibilityMapArrayElement> NodeVisibilityMapArray
		{
			get => GetPropertyValue<CArray<questNodeVisibilityMapArrayElement>>();
			set => SetPropertyValue<CArray<questNodeVisibilityMapArrayElement>>(value);
		}

		[Ordinal(1)] 
		[RED("isInMirrorsAreaMapArray")] 
		public CArray<questIsInMirrorsAreaMapArrayElement> IsInMirrorsAreaMapArray
		{
			get => GetPropertyValue<CArray<questIsInMirrorsAreaMapArrayElement>>();
			set => SetPropertyValue<CArray<questIsInMirrorsAreaMapArrayElement>>(value);
		}

		[Ordinal(2)] 
		[RED("nodeCollisionMapArray")] 
		public CArray<questNodeCollisionMapArrayElement> NodeCollisionMapArray
		{
			get => GetPropertyValue<CArray<questNodeCollisionMapArrayElement>>();
			set => SetPropertyValue<CArray<questNodeCollisionMapArrayElement>>(value);
		}

		[Ordinal(3)] 
		[RED("prefabVariants")] 
		public CArray<questPrefabVariantMapArrayElement> PrefabVariants
		{
			get => GetPropertyValue<CArray<questPrefabVariantMapArrayElement>>();
			set => SetPropertyValue<CArray<questPrefabVariantMapArrayElement>>(value);
		}

		public questWorldStateSystemReplicatedState()
		{
			NodeVisibilityMapArray = new();
			IsInMirrorsAreaMapArray = new();
			NodeCollisionMapArray = new();
			PrefabVariants = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
