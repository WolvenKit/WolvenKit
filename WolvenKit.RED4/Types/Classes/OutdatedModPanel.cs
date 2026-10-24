using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OutdatedModPanel : inkDiscreteNavigationController
	{
		[Ordinal(4)] 
		[RED("logoWidget")] 
		public inkImageWidgetReference LogoWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("modTitleText")] 
		public inkTextWidgetReference ModTitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("checkboxCanvas")] 
		public inkWidgetReference CheckboxCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("checkbox")] 
		public inkImageWidgetReference Checkbox
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("thumbnailCanvas")] 
		public inkWidgetReference ThumbnailCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("reasonInfoSpawner")] 
		public inkWidgetReference ReasonInfoSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("modCreatorText")] 
		public inkTextWidgetReference ModCreatorText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("modCreatorCanvas")] 
		public inkWidgetReference ModCreatorCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("imageBackgroundRef")] 
		public inkImageWidgetReference ImageBackgroundRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("outlineImageRef")] 
		public inkImageWidgetReference OutlineImageRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		[Ordinal(15)] 
		[RED("systemHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(16)] 
		[RED("modName")] 
		public CString ModName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(17)] 
		[RED("modID")] 
		public CInt64 ModID
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(18)] 
		[RED("bIsChecked")] 
		public CBool BIsChecked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("actionRequiredType1")] 
		public CWeakHandle<ModActionRequiredTypeInfoController> ActionRequiredType1
		{
			get => GetPropertyValue<CWeakHandle<ModActionRequiredTypeInfoController>>();
			set => SetPropertyValue<CWeakHandle<ModActionRequiredTypeInfoController>>(value);
		}

		[Ordinal(20)] 
		[RED("actionRequiredType2")] 
		public CWeakHandle<ModActionRequiredTypeInfoController> ActionRequiredType2
		{
			get => GetPropertyValue<CWeakHandle<ModActionRequiredTypeInfoController>>();
			set => SetPropertyValue<CWeakHandle<ModActionRequiredTypeInfoController>>(value);
		}

		[Ordinal(21)] 
		[RED("popupController")] 
		public CWeakHandle<ModioUpdateModsPopupController> PopupController
		{
			get => GetPropertyValue<CWeakHandle<ModioUpdateModsPopupController>>();
			set => SetPropertyValue<CWeakHandle<ModioUpdateModsPopupController>>(value);
		}

		[Ordinal(22)] 
		[RED("bEditableCheckboxState")] 
		public CBool BEditableCheckboxState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public OutdatedModPanel()
		{
			LogoWidget = new inkImageWidgetReference();
			ModTitleText = new inkTextWidgetReference();
			CheckboxCanvas = new inkWidgetReference();
			Checkbox = new inkImageWidgetReference();
			ThumbnailCanvas = new inkWidgetReference();
			ReasonInfoSpawner = new inkWidgetReference();
			ModCreatorText = new inkTextWidgetReference();
			ModCreatorCanvas = new inkWidgetReference();
			ImageBackgroundRef = new inkImageWidgetReference();
			OutlineImageRef = new inkImageWidgetReference();
			ColorNames = new ModsMenuColorsNames();
			BEditableCheckboxState = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
