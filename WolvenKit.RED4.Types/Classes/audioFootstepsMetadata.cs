using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioFootstepsMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("defaultFootwearMetadata")] 
		public CName DefaultFootwearMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("footwearMetadataArray")] 
		public CArray<CName> FootwearMetadataArray
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("slideEvent")] 
		public CName SlideEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("onEnterSound")] 
		public CName OnEnterSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("onExitSound")] 
		public CName OnExitSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioFootstepsMetadata()
		{
			FootwearMetadataArray = new();
		}
	}
}
