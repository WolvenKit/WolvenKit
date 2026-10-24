using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioGalleryFullPreview : GalleryFullPreview
	{
		[Ordinal(13)] 
		[RED("leftGalleryArrow")] 
		public inkWidgetReference LeftGalleryArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("rightGalleryArrow")] 
		public inkWidgetReference RightGalleryArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("galleryText")] 
		public inkTextWidgetReference GalleryText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("galleryTextShadow")] 
		public inkTextWidgetReference GalleryTextShadow
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("menuNavigationRef")] 
		public inkWidgetReference MenuNavigationRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("currentGalleryIndex")] 
		public CInt64 CurrentGalleryIndex
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(19)] 
		[RED("gallerySize")] 
		public CInt64 GallerySize
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(20)] 
		[RED("firstOpening")] 
		public CBool FirstOpening
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("menuNavigationController")] 
		public CWeakHandle<inkContainerNavigationController> MenuNavigationController
		{
			get => GetPropertyValue<CWeakHandle<inkContainerNavigationController>>();
			set => SetPropertyValue<CWeakHandle<inkContainerNavigationController>>(value);
		}

		[Ordinal(22)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(23)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public ModioGalleryFullPreview()
		{
			LeftGalleryArrow = new inkWidgetReference();
			RightGalleryArrow = new inkWidgetReference();
			GalleryText = new inkTextWidgetReference();
			GalleryTextShadow = new inkTextWidgetReference();
			MenuNavigationRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
