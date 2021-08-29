using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAudioAttractAreaNodeSettings : RedBaseClass
	{
		private CName _metadataName;

		[Ordinal(0)] 
		[RED("metadataName")] 
		public CName MetadataName
		{
			get => GetProperty(ref _metadataName);
			set => SetProperty(ref _metadataName, value);
		}
	}
}
