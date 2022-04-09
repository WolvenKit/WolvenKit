using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeGridList : inkRadioGroupController
	{
		[Ordinal(5)] 
		[RED("ScrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("ContentRoot")] 
		public inkWidgetReference ContentRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("SliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("rowOffset")] 
		public CInt32 RowOffset
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("firstOffset")] 
		public CInt32 FirstOffset
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("rowLibraryId")] 
		public CName RowLibraryId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("buttonLibraryId")] 
		public CName ButtonLibraryId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("parentListItem")] 
		public CWeakHandle<PhotoModeMenuListItem> ParentListItem
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeMenuListItem>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeMenuListItem>>(value);
		}

		[Ordinal(13)] 
		[RED("buttons")] 
		public CArray<CWeakHandle<PhotoModeGridButton>> Buttons
		{
			get => GetPropertyValue<CArray<CWeakHandle<PhotoModeGridButton>>>();
			set => SetPropertyValue<CArray<CWeakHandle<PhotoModeGridButton>>>(value);
		}

		[Ordinal(14)] 
		[RED("rows")] 
		public CArray<CWeakHandle<inkWidget>> Rows
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(15)] 
		[RED("sliderController")] 
		public CWeakHandle<inkSliderController> SliderController
		{
			get => GetPropertyValue<CWeakHandle<inkSliderController>>();
			set => SetPropertyValue<CWeakHandle<inkSliderController>>(value);
		}

		[Ordinal(16)] 
		[RED("ItemsInRow")] 
		public CInt32 ItemsInRow
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("RowsCount")] 
		public CInt32 RowsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("SelectedIndex")] 
		public CInt32 SelectedIndex_168
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("PreviousSelectedIndex")] 
		public CInt32 PreviousSelectedIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("visibleSize")] 
		public CFloat VisibleSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("visibleRows")] 
		public CInt32 VisibleRows
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(22)] 
		[RED("scrollRow")] 
		public CInt32 ScrollRow
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("isVisibleOnscreen")] 
		public CBool IsVisibleOnscreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PhotoModeGridList()
		{
			ScrollArea = new();
			ContentRoot = new();
			SliderWidget = new();
			Buttons = new();
			Rows = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
