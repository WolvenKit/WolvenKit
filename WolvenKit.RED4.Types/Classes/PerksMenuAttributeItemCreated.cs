using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerksMenuAttributeItemCreated : redEvent
	{
		[Ordinal(0)] 
		[RED("perksMenuAttributeItem")] 
		public CWeakHandle<PerksMenuAttributeItemController> PerksMenuAttributeItem
		{
			get => GetPropertyValue<CWeakHandle<PerksMenuAttributeItemController>>();
			set => SetPropertyValue<CWeakHandle<PerksMenuAttributeItemController>>(value);
		}
	}
}
