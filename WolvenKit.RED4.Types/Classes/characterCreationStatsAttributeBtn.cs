using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationStatsAttributeBtn : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("addBtn")] 
		public inkWidgetReference AddBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("addBtnhitArea")] 
		public inkWidgetReference AddBtnhitArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("minusBtn")] 
		public inkWidgetReference MinusBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("minusBtnhitArea")] 
		public inkWidgetReference MinusBtnhitArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("minMaxLabel")] 
		public inkWidgetReference MinMaxLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("minMaxLabelText")] 
		public inkTextWidgetReference MinMaxLabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("minusBtnNONE")] 
		public inkWidgetReference MinusBtnNONE
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("addBtnNONE")] 
		public inkWidgetReference AddBtnNONE
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<CharacterCreationAttributeData> Data
		{
			get => GetPropertyValue<CHandle<CharacterCreationAttributeData>>();
			set => SetPropertyValue<CHandle<CharacterCreationAttributeData>>(value);
		}

		[Ordinal(12)] 
		[RED("animating")] 
		public CBool Animating
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("minusEnabled")] 
		public CBool MinusEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("addEnabled")] 
		public CBool AddEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("maxed")] 
		public CBool Maxed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("addBtnState")] 
		public CEnum<AttributeButtonState> AddBtnState
		{
			get => GetPropertyValue<CEnum<AttributeButtonState>>();
			set => SetPropertyValue<CEnum<AttributeButtonState>>(value);
		}

		[Ordinal(17)] 
		[RED("minusBtnState")] 
		public CEnum<AttributeButtonState> MinusBtnState
		{
			get => GetPropertyValue<CEnum<AttributeButtonState>>();
			set => SetPropertyValue<CEnum<AttributeButtonState>>(value);
		}

		[Ordinal(18)] 
		[RED("state")] 
		public CEnum<AttributeButtonState> State
		{
			get => GetPropertyValue<CEnum<AttributeButtonState>>();
			set => SetPropertyValue<CEnum<AttributeButtonState>>(value);
		}

		public characterCreationStatsAttributeBtn()
		{
			Value = new();
			Label = new();
			AddBtn = new();
			AddBtnhitArea = new();
			MinusBtn = new();
			MinusBtnhitArea = new();
			MinMaxLabel = new();
			MinMaxLabelText = new();
			MinusBtnNONE = new();
			AddBtnNONE = new();
		}
	}
}
