using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemChooserItemHoverOut : redEvent
	{
		[Ordinal(0)] 
		[RED("sourceEvent")] 
		public CHandle<inkPointerEvent> SourceEvent
		{
			get => GetPropertyValue<CHandle<inkPointerEvent>>();
			set => SetPropertyValue<CHandle<inkPointerEvent>>(value);
		}

		public ItemChooserItemHoverOut()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
