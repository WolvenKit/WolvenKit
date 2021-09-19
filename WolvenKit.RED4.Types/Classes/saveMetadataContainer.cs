using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Metadata = new() { SaveVersion = 209, GameVersion = 1301 };
		}
	}
}
