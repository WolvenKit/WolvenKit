using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationStatsAttributeBtn : inkWidgetLogicController
	{
		private inkTextWidgetReference _value;
		private inkTextWidgetReference _label;
		private inkWidgetReference _addBtn;
		private inkWidgetReference _addBtnhitArea;
		private inkWidgetReference _minusBtn;
		private inkWidgetReference _minusBtnhitArea;
		private inkWidgetReference _minMaxLabel;
		private inkTextWidgetReference _minMaxLabelText;
		private inkWidgetReference _minusBtnNONE;
		private inkWidgetReference _addBtnNONE;
		private CHandle<CharacterCreationAttributeData> _data;
		private CBool _animating;
		private CBool _minusEnabled;
		private CBool _addEnabled;
		private CBool _maxed;
		private CEnum<AttributeButtonState> _addBtnState;
		private CEnum<AttributeButtonState> _minusBtnState;
		private CEnum<AttributeButtonState> _state;

		[Ordinal(1)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(3)] 
		[RED("addBtn")] 
		public inkWidgetReference AddBtn
		{
			get => GetProperty(ref _addBtn);
			set => SetProperty(ref _addBtn, value);
		}

		[Ordinal(4)] 
		[RED("addBtnhitArea")] 
		public inkWidgetReference AddBtnhitArea
		{
			get => GetProperty(ref _addBtnhitArea);
			set => SetProperty(ref _addBtnhitArea, value);
		}

		[Ordinal(5)] 
		[RED("minusBtn")] 
		public inkWidgetReference MinusBtn
		{
			get => GetProperty(ref _minusBtn);
			set => SetProperty(ref _minusBtn, value);
		}

		[Ordinal(6)] 
		[RED("minusBtnhitArea")] 
		public inkWidgetReference MinusBtnhitArea
		{
			get => GetProperty(ref _minusBtnhitArea);
			set => SetProperty(ref _minusBtnhitArea, value);
		}

		[Ordinal(7)] 
		[RED("minMaxLabel")] 
		public inkWidgetReference MinMaxLabel
		{
			get => GetProperty(ref _minMaxLabel);
			set => SetProperty(ref _minMaxLabel, value);
		}

		[Ordinal(8)] 
		[RED("minMaxLabelText")] 
		public inkTextWidgetReference MinMaxLabelText
		{
			get => GetProperty(ref _minMaxLabelText);
			set => SetProperty(ref _minMaxLabelText, value);
		}

		[Ordinal(9)] 
		[RED("minusBtnNONE")] 
		public inkWidgetReference MinusBtnNONE
		{
			get => GetProperty(ref _minusBtnNONE);
			set => SetProperty(ref _minusBtnNONE, value);
		}

		[Ordinal(10)] 
		[RED("addBtnNONE")] 
		public inkWidgetReference AddBtnNONE
		{
			get => GetProperty(ref _addBtnNONE);
			set => SetProperty(ref _addBtnNONE, value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<CharacterCreationAttributeData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(12)] 
		[RED("animating")] 
		public CBool Animating
		{
			get => GetProperty(ref _animating);
			set => SetProperty(ref _animating, value);
		}

		[Ordinal(13)] 
		[RED("minusEnabled")] 
		public CBool MinusEnabled
		{
			get => GetProperty(ref _minusEnabled);
			set => SetProperty(ref _minusEnabled, value);
		}

		[Ordinal(14)] 
		[RED("addEnabled")] 
		public CBool AddEnabled
		{
			get => GetProperty(ref _addEnabled);
			set => SetProperty(ref _addEnabled, value);
		}

		[Ordinal(15)] 
		[RED("maxed")] 
		public CBool Maxed
		{
			get => GetProperty(ref _maxed);
			set => SetProperty(ref _maxed, value);
		}

		[Ordinal(16)] 
		[RED("addBtnState")] 
		public CEnum<AttributeButtonState> AddBtnState
		{
			get => GetProperty(ref _addBtnState);
			set => SetProperty(ref _addBtnState, value);
		}

		[Ordinal(17)] 
		[RED("minusBtnState")] 
		public CEnum<AttributeButtonState> MinusBtnState
		{
			get => GetProperty(ref _minusBtnState);
			set => SetProperty(ref _minusBtnState, value);
		}

		[Ordinal(18)] 
		[RED("state")] 
		public CEnum<AttributeButtonState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
