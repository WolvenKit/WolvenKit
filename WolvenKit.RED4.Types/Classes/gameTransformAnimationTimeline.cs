using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimationTimeline : RedBaseClass
	{
		private CArray<gameTransformAnimationTrackItem> _items;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<gameTransformAnimationTrackItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
