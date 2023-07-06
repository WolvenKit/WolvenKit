using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkScrollController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("ScrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("VerticalScrollBarRef")] 
		public inkWidgetReference VerticalScrollBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("navigableCompoundWidget")] 
		public inkWidgetReference NavigableCompoundWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("CompoundWidgetRef")] 
		public inkCompoundWidgetReference CompoundWidgetRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("autoHideVertical")] 
		public CBool AutoHideVertical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("scrollSpeedGamepad")] 
		public CFloat ScrollSpeedGamepad
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("scrollSpeedMouse")] 
		public CFloat ScrollSpeedMouse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("direction")] 
		public CEnum<inkEScrollDirection> Direction
		{
			get => GetPropertyValue<CEnum<inkEScrollDirection>>();
			set => SetPropertyValue<CEnum<inkEScrollDirection>>(value);
		}

		[Ordinal(9)] 
		[RED("useGlobalInput")] 
		public CBool UseGlobalInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("position")] 
		public CFloat Position
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("desiredSetupPosition")] 
		public CFloat DesiredSetupPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("contentSmallerThanViewport")] 
		public CBool ContentSmallerThanViewport
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("scrollDelta")] 
		public CFloat ScrollDelta
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("viewportSize")] 
		public Vector2 ViewportSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(15)] 
		[RED("contentSize")] 
		public Vector2 ContentSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public inkScrollController()
		{
			ScrollArea = new inkScrollAreaWidgetReference();
			VerticalScrollBarRef = new inkWidgetReference();
			NavigableCompoundWidget = new inkWidgetReference();
			CompoundWidgetRef = new inkCompoundWidgetReference();
			AutoHideVertical = true;
			ScrollSpeedGamepad = 75.000000F;
			ScrollSpeedMouse = 75.000000F;
			ContentSmallerThanViewport = true;
			ViewportSize = new Vector2();
			ContentSize = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
