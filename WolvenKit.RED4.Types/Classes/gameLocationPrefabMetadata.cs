using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLocationPrefabMetadata : worldPrefabMetadata
	{
		private CArray<CName> _tags;
		private CBool _ignoreParentPrefabs;

		[Ordinal(0)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(1)] 
		[RED("ignoreParentPrefabs")] 
		public CBool IgnoreParentPrefabs
		{
			get => GetProperty(ref _ignoreParentPrefabs);
			set => SetProperty(ref _ignoreParentPrefabs, value);
		}
	}
}
