using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class YaibaOptionPreview : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("selectionPreviewRef")] 
		public inkWidgetReference SelectionPreviewRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("removalPreviewRef")] 
		public inkWidgetReference RemovalPreviewRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("selectionAnimName")] 
		public CName SelectionAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("removalAnimName")] 
		public CName RemovalAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isAnimated")] 
		public CBool IsAnimated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public YaibaOptionPreview()
		{
			SelectionPreviewRef = new inkWidgetReference();
			RemovalPreviewRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
