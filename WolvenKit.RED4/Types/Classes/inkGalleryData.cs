using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGalleryData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("favorites")] 
		public CArray<CUInt32> Favorites
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public inkGalleryData()
		{
			Favorites = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
