using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EmptySlotItem : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("imageContainer")] 
		public inkWidgetReference ImageContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public EmptySlotItem()
		{
			ImageContainer = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
