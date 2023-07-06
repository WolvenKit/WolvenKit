using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeGridButton : inkToggleController
	{
		[Ordinal(13)] 
		[RED("FrameImg")] 
		public inkImageWidgetReference FrameImg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("DynamicImg")] 
		public inkImageWidgetReference DynamicImg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("BgWidget")] 
		public inkWidgetReference BgWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("HoverWidget")] 
		public inkWidgetReference HoverWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("PlusImg")] 
		public inkImageWidgetReference PlusImg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("currentImagePart")] 
		public CName CurrentImagePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("atlasRef")] 
		public redResourceReferenceScriptToken AtlasRef
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(20)] 
		[RED("buttonData")] 
		public CInt32 ButtonData
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("parentGrid")] 
		public CWeakHandle<PhotoModeGridList> ParentGrid
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeGridList>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeGridList>>(value);
		}

		[Ordinal(22)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("visibleOnGrid")] 
		public CBool VisibleOnGrid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("imageScalingSpeed")] 
		public CFloat ImageScalingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
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
