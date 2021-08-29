using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkSingleDrawMetric : RedBaseClass
	{
		private CBool _exeedsLimit;
		private Vector2 _hierarchySize;
		private CArray<CUInt32> _usedTextures;

		[Ordinal(0)] 
		[RED("exeedsLimit")] 
		public CBool ExeedsLimit
		{
			get => GetProperty(ref _exeedsLimit);
			set => SetProperty(ref _exeedsLimit, value);
		}

		[Ordinal(1)] 
		[RED("hierarchySize")] 
		public Vector2 HierarchySize
		{
			get => GetProperty(ref _hierarchySize);
			set => SetProperty(ref _hierarchySize, value);
		}

		[Ordinal(2)] 
		[RED("usedTextures")] 
		public CArray<CUInt32> UsedTextures
		{
			get => GetProperty(ref _usedTextures);
			set => SetProperty(ref _usedTextures, value);
		}
	}
}
