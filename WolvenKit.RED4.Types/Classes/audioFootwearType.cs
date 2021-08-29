using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioFootwearType : audioAudioMetadata
	{
		private CArray<CName> _itemNames;

		[Ordinal(1)] 
		[RED("itemNames")] 
		public CArray<CName> ItemNames
		{
			get => GetProperty(ref _itemNames);
			set => SetProperty(ref _itemNames, value);
		}
	}
}
