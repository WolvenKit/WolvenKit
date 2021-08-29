using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class saveMetadataContainer : ISerializable
	{
		private saveMetadata _metadata;

		[Ordinal(0)] 
		[RED("metadata")] 
		public saveMetadata Metadata
		{
			get => GetProperty(ref _metadata);
			set => SetProperty(ref _metadata, value);
		}
	}
}
