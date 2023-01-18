using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkSingleDrawMetric : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("exeedsLimit")] 
		public CBool ExeedsLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("hierarchySize")] 
		public Vector2 HierarchySize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("usedTextures")] 
		public CArray<CUInt32> UsedTextures
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public inkSingleDrawMetric()
		{
			HierarchySize = new();
			UsedTextures = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
