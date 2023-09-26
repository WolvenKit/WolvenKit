using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GogRewardsListController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("containerWidget")] 
		public inkWidgetReference ContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("scrollArea")] 
		public inkWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("sizeRefWrapper")] 
		public inkWidgetReference SizeRefWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("scrollBarRequiredHeight")] 
		public CInt32 ScrollBarRequiredHeight
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("shouldUpdateLayout")] 
		public CBool ShouldUpdateLayout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GogRewardsListController()
		{
			ContainerWidget = new inkWidgetReference();
			ScrollArea = new inkWidgetReference();
			SizeRefWrapper = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
