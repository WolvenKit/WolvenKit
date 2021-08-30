using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkSelectorController : inkWidgetLogicController
	{
		private CInt32 _index;
		private CArray<CString> _values;
		private CBool _cycledNavigation;
		private inkSelectionChangeCallback _selectionChanged;
		private CName _labelPath;
		private CName _valuePath;
		private CName _leftArrowPath;
		private CName _rightArrowPath;
		private CWeakHandle<inkTextWidget> _label;
		private CWeakHandle<inkTextWidget> _value;
		private CWeakHandle<inkWidget> _leftArrow;
		private CWeakHandle<inkWidget> _rightArrow;
		private CWeakHandle<inkButtonController> _rightArrowButton;
		private CWeakHandle<inkButtonController> _leftArrowButton;

		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(2)] 
		[RED("values")] 
		public CArray<CString> Values
		{
			get => GetProperty(ref _values);
			set => SetProperty(ref _values, value);
		}

		[Ordinal(3)] 
		[RED("cycledNavigation")] 
		public CBool CycledNavigation
		{
			get => GetProperty(ref _cycledNavigation);
			set => SetProperty(ref _cycledNavigation, value);
		}

		[Ordinal(4)] 
		[RED("SelectionChanged")] 
		public inkSelectionChangeCallback SelectionChanged
		{
			get => GetProperty(ref _selectionChanged);
			set => SetProperty(ref _selectionChanged, value);
		}

		[Ordinal(5)] 
		[RED("labelPath")] 
		public CName LabelPath
		{
			get => GetProperty(ref _labelPath);
			set => SetProperty(ref _labelPath, value);
		}

		[Ordinal(6)] 
		[RED("valuePath")] 
		public CName ValuePath
		{
			get => GetProperty(ref _valuePath);
			set => SetProperty(ref _valuePath, value);
		}

		[Ordinal(7)] 
		[RED("leftArrowPath")] 
		public CName LeftArrowPath
		{
			get => GetProperty(ref _leftArrowPath);
			set => SetProperty(ref _leftArrowPath, value);
		}

		[Ordinal(8)] 
		[RED("rightArrowPath")] 
		public CName RightArrowPath
		{
			get => GetProperty(ref _rightArrowPath);
			set => SetProperty(ref _rightArrowPath, value);
		}

		[Ordinal(9)] 
		[RED("label")] 
		public CWeakHandle<inkTextWidget> Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(10)] 
		[RED("value")] 
		public CWeakHandle<inkTextWidget> Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(11)] 
		[RED("leftArrow")] 
		public CWeakHandle<inkWidget> LeftArrow
		{
			get => GetProperty(ref _leftArrow);
			set => SetProperty(ref _leftArrow, value);
		}

		[Ordinal(12)] 
		[RED("rightArrow")] 
		public CWeakHandle<inkWidget> RightArrow
		{
			get => GetProperty(ref _rightArrow);
			set => SetProperty(ref _rightArrow, value);
		}

		[Ordinal(13)] 
		[RED("rightArrowButton")] 
		public CWeakHandle<inkButtonController> RightArrowButton
		{
			get => GetProperty(ref _rightArrowButton);
			set => SetProperty(ref _rightArrowButton, value);
		}

		[Ordinal(14)] 
		[RED("leftArrowButton")] 
		public CWeakHandle<inkButtonController> LeftArrowButton
		{
			get => GetProperty(ref _leftArrowButton);
			set => SetProperty(ref _leftArrowButton, value);
		}

		public inkSelectorController()
		{
			_index = -1;
			_cycledNavigation = true;
			_labelPath = "Panel/Label";
			_valuePath = "Panel/Value";
			_leftArrowPath = "Panel/LeftArrow";
			_rightArrowPath = "Panel/RightArrow";
		}
	}
}
