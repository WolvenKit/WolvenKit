using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameElementController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("data")] 
		public ElementData Data
		{
			get => GetPropertyValue<ElementData>();
			set => SetPropertyValue<ElementData>(value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("textNormalColor")] 
		public CColor TextNormalColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(4)] 
		[RED("textHighlightColor")] 
		public CColor TextHighlightColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(5)] 
		[RED("bg")] 
		public inkRectangleWidgetReference Bg
		{
			get => GetPropertyValue<inkRectangleWidgetReference>();
			set => SetPropertyValue<inkRectangleWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("colorAccent")] 
		public inkWidgetReference ColorAccent
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("dimmedOpacity")] 
		public CFloat DimmedOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("notDimmedOpacity")] 
		public CFloat NotDimmedOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("defaultFontSize")] 
		public CInt32 DefaultFontSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("wasConsumed")] 
		public CBool WasConsumed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public NetworkMinigameElementController()
		{
			Data = new ElementData();
			Text = new inkTextWidgetReference();
			TextNormalColor = new CColor();
			TextHighlightColor = new CColor();
			Bg = new inkRectangleWidgetReference();
			ColorAccent = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
