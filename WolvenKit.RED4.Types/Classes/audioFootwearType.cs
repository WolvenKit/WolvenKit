using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioFootwearType : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("itemNames")] 
		public CArray<CName> ItemNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioFootwearType()
		{
			ItemNames = new();
		}
	}
}
