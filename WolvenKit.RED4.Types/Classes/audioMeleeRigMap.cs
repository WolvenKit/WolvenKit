using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeRigMap : audioAudioMetadata
	{
		private CArray<audioMeleeRigMapItem> _mapItems;

		[Ordinal(1)] 
		[RED("mapItems")] 
		public CArray<audioMeleeRigMapItem> MapItems
		{
			get => GetProperty(ref _mapItems);
			set => SetProperty(ref _mapItems, value);
		}
	}
}
