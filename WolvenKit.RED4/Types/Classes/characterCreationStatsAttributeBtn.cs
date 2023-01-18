using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttons")] 
		public inkImageWidgetReference Buttons
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("selector")] 
		public inkImageWidgetReference Selector
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("addBtnhitArea")] 
		public inkWidgetReference AddBtnhitArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("minusBtnhitArea")] 
		public inkWidgetReference MinusBtnhitArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("minMaxLabel")] 
		public inkWidgetReference MinMaxLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("minMaxLabelText")] 
		public inkTextWidgetReference MinMaxLabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("data")] 
		public CHandle<CharacterCreationAttributeData> Data
		{
			get => GetPropertyValue<CHandle<CharacterCreationAttributeData>>();
			set => SetPropertyValue<CHandle<CharacterCreationAttributeData>>(value);
		}

		[Ordinal(11)] 
		[RED("animating")] 
		public CBool Animating
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("minusEnabled")] 
		public CBool MinusEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("addEnabled")] 
		public CBool AddEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("maxed")] 
		public CBool Maxed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isPlusOrMinusBtnHoveredOver")] 
		public CBool IsPlusOrMinusBtnHoveredOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public characterCreationStatsAttributeBtn()
		{
			Value = new();
			Label = new();
			Icon = new();
			Buttons = new();
			Selector = new();
			AddBtnhitArea = new();
			MinusBtnhitArea = new();
			MinMaxLabel = new();
			MinMaxLabelText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
