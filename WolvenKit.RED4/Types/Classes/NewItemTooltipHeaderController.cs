using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipHeaderController : NewItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("dualWieldWeaponSlotText")] 
		public inkTextWidgetReference DualWieldWeaponSlotText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("comparisionArrow")] 
		public inkWidgetReference ComparisionArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("itemEvolutionIcon")] 
		public inkImageWidgetReference ItemEvolutionIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("itemPerkIcon")] 
		public inkImageWidgetReference ItemPerkIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("itemWeaponIcon")] 
		public inkImageWidgetReference ItemWeaponIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("separatorTop")] 
		public inkWidgetReference SeparatorTop
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("dualWieldWrapper")] 
		public inkWidgetReference DualWieldWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("dualWieldPrimaryIcons")] 
		public inkWidgetReference DualWieldPrimaryIcons
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("dualWieldSecondaryIcons")] 
		public inkWidgetReference DualWieldSecondaryIcons
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("localizedIconicText")] 
		public CString LocalizedIconicText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public NewItemTooltipHeaderController()
		{
			ItemNameText = new inkTextWidgetReference();
			ItemRarityText = new inkTextWidgetReference();
			ItemTypeText = new inkTextWidgetReference();
			DualWieldWeaponSlotText = new inkTextWidgetReference();
			ComparisionArrow = new inkWidgetReference();
			ItemEvolutionIcon = new inkImageWidgetReference();
			ItemPerkIcon = new inkImageWidgetReference();
			ItemWeaponIcon = new inkImageWidgetReference();
			SeparatorTop = new inkWidgetReference();
			DualWieldWrapper = new inkWidgetReference();
			DualWieldPrimaryIcons = new inkWidgetReference();
			DualWieldSecondaryIcons = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
