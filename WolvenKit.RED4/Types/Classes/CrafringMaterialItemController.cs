using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrafringMaterialItemController : BaseButtonView
	{
		[Ordinal(5)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("quantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("quantityChangeText")] 
		public inkTextWidgetReference QuantityChangeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("frame")] 
		public inkWidgetReference Frame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("data")] 
		public CHandle<CachedCraftingMaterial> Data
		{
			get => GetPropertyValue<CHandle<CachedCraftingMaterial>>();
			set => SetPropertyValue<CHandle<CachedCraftingMaterial>>(value);
		}

		[Ordinal(11)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("lastState")] 
		public CEnum<CrafringMaterialItemHighlight> LastState
		{
			get => GetPropertyValue<CEnum<CrafringMaterialItemHighlight>>();
			set => SetPropertyValue<CEnum<CrafringMaterialItemHighlight>>(value);
		}

		[Ordinal(14)] 
		[RED("shouldBeHighlighted")] 
		public CBool ShouldBeHighlighted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("useSimpleFromat")] 
		public CBool UseSimpleFromat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("hideIfZero")] 
		public CBool HideIfZero
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CrafringMaterialItemController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
