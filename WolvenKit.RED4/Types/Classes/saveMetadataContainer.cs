using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class saveMetadataContainer : ISerializable
	{
		[Ordinal(0)] 
		[RED("metadata")] 
		public saveMetadata Metadata
		{
			get => GetPropertyValue<saveMetadata>();
			set => SetPropertyValue<saveMetadata>(value);
		}

		public saveMetadataContainer()
		{
			Metadata = new saveMetadata { SaveVersion = 269, GameVersion = 2300, AdditionalContentIds = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
