using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGalleryDataContainer : ISerializable
	{
		[Ordinal(0)] 
		[RED("data")] 
		public inkGalleryData Data
		{
			get => GetPropertyValue<inkGalleryData>();
			set => SetPropertyValue<inkGalleryData>(value);
		}

		public inkGalleryDataContainer()
		{
			Data = new inkGalleryData { Favorites = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
