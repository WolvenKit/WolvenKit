using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeGridButton : inkToggleController
	{
		[Ordinal(16)] 
		[RED("FrameImg")] 
		public inkImageWidgetReference FrameImg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("DynamicImg")] 
		public inkImageWidgetReference DynamicImg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("BgWidget")] 
		public inkWidgetReference BgWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("HoverWidget")] 
		public inkWidgetReference HoverWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("PlusImg")] 
		public inkImageWidgetReference PlusImg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("currentImagePart")] 
		public CName CurrentImagePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("atlasRef")] 
		public redResourceReferenceScriptToken AtlasRef
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(23)] 
		[RED("buttonData")] 
		public CInt32 ButtonData
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("parentGrid")] 
		public CWeakHandle<PhotoModeGridList> ParentGrid
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeGridList>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeGridList>>(value);
		}

		[Ordinal(25)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(26)] 
		[RED("visibleOnGrid")] 
		public CBool VisibleOnGrid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("alwaysVisible")] 
		public CBool AlwaysVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("imageScalingSpeed")] 
		public CFloat ImageScalingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("opacityScalingSpeed")] 
		public CFloat OpacityScalingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PhotoModeGridButton()
		{
			FrameImg = new inkImageWidgetReference();
			DynamicImg = new inkImageWidgetReference();
			BgWidget = new inkWidgetReference();
			HoverWidget = new inkWidgetReference();
			PlusImg = new inkImageWidgetReference();
			AtlasRef = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
