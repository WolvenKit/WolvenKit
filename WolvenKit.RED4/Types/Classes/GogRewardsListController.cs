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
		[RED("cyberpunkShopUrl")] 
		public inkWidgetReference CyberpunkShopUrl
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("scrollBarRequiredHeight")] 
		public CInt32 ScrollBarRequiredHeight
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("disconnectBtn")] 
		public inkWidgetReference DisconnectBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("shouldUpdateLayout")] 
		public CBool ShouldUpdateLayout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("signOutEnabled")] 
		public CBool SignOutEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GogRewardsListController()
		{
			ContainerWidget = new inkWidgetReference();
			ScrollArea = new inkWidgetReference();
			SizeRefWrapper = new inkWidgetReference();
			CyberpunkShopUrl = new inkWidgetReference();
			DisconnectBtn = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
