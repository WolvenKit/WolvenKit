using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrack : effectTrackBase
	{
		private CArray<CHandle<effectTrackItem>> _items;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<CHandle<effectTrackItem>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
