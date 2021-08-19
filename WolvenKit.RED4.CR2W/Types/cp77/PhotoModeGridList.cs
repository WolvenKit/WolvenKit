using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeGridList : inkRadioGroupController
	{
		private inkScrollAreaWidgetReference _scrollArea;
		private inkWidgetReference _contentRoot;
		private inkWidgetReference _sliderWidget;
		private CInt32 _rowOffset;
		private CInt32 _firstOffset;
		private CName _rowLibraryId;
		private CName _buttonLibraryId;
		private wCHandle<PhotoModeMenuListItem> _parentListItem;
		private CArray<wCHandle<PhotoModeGridButton>> _buttons;
		private CArray<wCHandle<inkWidget>> _rows;
		private wCHandle<inkSliderController> _sliderController;
		private CInt32 _itemsInRow;
		private CInt32 _rowsCount;
		private CInt32 _selectedIndex_168;
		private CInt32 _previousSelectedIndex;
		private CFloat _visibleSize;
		private CInt32 _visibleRows;
		private CInt32 _scrollRow;
		private CBool _isVisibleOnscreen;

		[Ordinal(5)] 
		[RED("ScrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetProperty(ref _scrollArea);
			set => SetProperty(ref _scrollArea, value);
		}

		[Ordinal(6)] 
		[RED("ContentRoot")] 
		public inkWidgetReference ContentRoot
		{
			get => GetProperty(ref _contentRoot);
			set => SetProperty(ref _contentRoot, value);
		}

		[Ordinal(7)] 
		[RED("SliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetProperty(ref _sliderWidget);
			set => SetProperty(ref _sliderWidget, value);
		}

		[Ordinal(8)] 
		[RED("rowOffset")] 
		public CInt32 RowOffset
		{
			get => GetProperty(ref _rowOffset);
			set => SetProperty(ref _rowOffset, value);
		}

		[Ordinal(9)] 
		[RED("firstOffset")] 
		public CInt32 FirstOffset
		{
			get => GetProperty(ref _firstOffset);
			set => SetProperty(ref _firstOffset, value);
		}

		[Ordinal(10)] 
		[RED("rowLibraryId")] 
		public CName RowLibraryId
		{
			get => GetProperty(ref _rowLibraryId);
			set => SetProperty(ref _rowLibraryId, value);
		}

		[Ordinal(11)] 
		[RED("buttonLibraryId")] 
		public CName ButtonLibraryId
		{
			get => GetProperty(ref _buttonLibraryId);
			set => SetProperty(ref _buttonLibraryId, value);
		}

		[Ordinal(12)] 
		[RED("parentListItem")] 
		public wCHandle<PhotoModeMenuListItem> ParentListItem
		{
			get => GetProperty(ref _parentListItem);
			set => SetProperty(ref _parentListItem, value);
		}

		[Ordinal(13)] 
		[RED("buttons")] 
		public CArray<wCHandle<PhotoModeGridButton>> Buttons
		{
			get => GetProperty(ref _buttons);
			set => SetProperty(ref _buttons, value);
		}

		[Ordinal(14)] 
		[RED("rows")] 
		public CArray<wCHandle<inkWidget>> Rows
		{
			get => GetProperty(ref _rows);
			set => SetProperty(ref _rows, value);
		}

		[Ordinal(15)] 
		[RED("sliderController")] 
		public wCHandle<inkSliderController> SliderController
		{
			get => GetProperty(ref _sliderController);
			set => SetProperty(ref _sliderController, value);
		}

		[Ordinal(16)] 
		[RED("ItemsInRow")] 
		public CInt32 ItemsInRow
		{
			get => GetProperty(ref _itemsInRow);
			set => SetProperty(ref _itemsInRow, value);
		}

		[Ordinal(17)] 
		[RED("RowsCount")] 
		public CInt32 RowsCount
		{
			get => GetProperty(ref _rowsCount);
			set => SetProperty(ref _rowsCount, value);
		}

		[Ordinal(18)] 
		[RED("SelectedIndex")] 
		public CInt32 SelectedIndex_168
		{
			get => GetProperty(ref _selectedIndex_168);
			set => SetProperty(ref _selectedIndex_168, value);
		}

		[Ordinal(19)] 
		[RED("PreviousSelectedIndex")] 
		public CInt32 PreviousSelectedIndex
		{
			get => GetProperty(ref _previousSelectedIndex);
			set => SetProperty(ref _previousSelectedIndex, value);
		}

		[Ordinal(20)] 
		[RED("visibleSize")] 
		public CFloat VisibleSize
		{
			get => GetProperty(ref _visibleSize);
			set => SetProperty(ref _visibleSize, value);
		}

		[Ordinal(21)] 
		[RED("visibleRows")] 
		public CInt32 VisibleRows
		{
			get => GetProperty(ref _visibleRows);
			set => SetProperty(ref _visibleRows, value);
		}

		[Ordinal(22)] 
		[RED("scrollRow")] 
		public CInt32 ScrollRow
		{
			get => GetProperty(ref _scrollRow);
			set => SetProperty(ref _scrollRow, value);
		}

		[Ordinal(23)] 
		[RED("isVisibleOnscreen")] 
		public CBool IsVisibleOnscreen
		{
			get => GetProperty(ref _isVisibleOnscreen);
			set => SetProperty(ref _isVisibleOnscreen, value);
		}

		public PhotoModeGridList(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
