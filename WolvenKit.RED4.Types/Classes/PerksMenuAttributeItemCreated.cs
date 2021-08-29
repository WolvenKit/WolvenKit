using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerksMenuAttributeItemCreated : redEvent
	{
		private CWeakHandle<PerksMenuAttributeItemController> _perksMenuAttributeItem;

		[Ordinal(0)] 
		[RED("perksMenuAttributeItem")] 
		public CWeakHandle<PerksMenuAttributeItemController> PerksMenuAttributeItem
		{
			get => GetProperty(ref _perksMenuAttributeItem);
			set => SetProperty(ref _perksMenuAttributeItem, value);
		}
	}
}
