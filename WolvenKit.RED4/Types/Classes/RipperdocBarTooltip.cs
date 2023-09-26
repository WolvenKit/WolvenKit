using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocBarTooltip : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("statsHolder")] 
		public inkWidgetReference StatsHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("perksHolder")] 
		public inkWidgetReference PerksHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("capacityDescription")] 
		public inkWidgetReference CapacityDescription
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("armorDescription")] 
		public inkWidgetReference ArmorDescription
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("armorReductionDescription")] 
		public inkTextWidgetReference ArmorReductionDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("titleHolder")] 
		public inkWidgetReference TitleHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("titleName")] 
		public inkTextWidgetReference TitleName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("titleTotalValue")] 
		public inkTextWidgetReference TitleTotalValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("titleMaxValue")] 
		public inkTextWidgetReference TitleMaxValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("stats1")] 
		public inkWidgetReference Stats1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("stats1Name")] 
		public inkTextWidgetReference Stats1Name
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("stats1Value")] 
		public inkTextWidgetReference Stats1Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("stats2")] 
		public inkWidgetReference Stats2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("stats2Name")] 
		public inkTextWidgetReference Stats2Name
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("stats2Value")] 
		public inkTextWidgetReference Stats2Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("stats3")] 
		public inkWidgetReference Stats3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("stats3Name")] 
		public inkTextWidgetReference Stats3Name
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("stats3Value")] 
		public inkTextWidgetReference Stats3Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("perkTypeName")] 
		public inkTextWidgetReference PerkTypeName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("perk1")] 
		public inkWidgetReference Perk1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("perk1Icon")] 
		public inkImageWidgetReference Perk1Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("perk1Name")] 
		public inkTextWidgetReference Perk1Name
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("perk2")] 
		public inkWidgetReference Perk2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("perk2Icon")] 
		public inkImageWidgetReference Perk2Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("perk2Name")] 
		public inkTextWidgetReference Perk2Name
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("perkTreeInput")] 
		public inkWidgetReference PerkTreeInput
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("perkTreeIcon")] 
		public inkImageWidgetReference PerkTreeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("capacityTitleNameLocKey")] 
		public CName CapacityTitleNameLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("capacityStat1LocKey")] 
		public CName CapacityStat1LocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("capacityStat2LocKey")] 
		public CName CapacityStat2LocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("capacityStat3LocKey")] 
		public CName CapacityStat3LocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("capacityPerkTitleLocKey")] 
		public CName CapacityPerkTitleLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("capacityPerk1IconsName")] 
		public CName CapacityPerk1IconsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("capacityPerk1LocKey")] 
		public CName CapacityPerk1LocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(36)] 
		[RED("capacityPerk2IconsName")] 
		public CName CapacityPerk2IconsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("capacityPerk2LocKey")] 
		public CName CapacityPerk2LocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("armorTitleNameLocKey")] 
		public CName ArmorTitleNameLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(39)] 
		[RED("armorStat1LocKey")] 
		public CName ArmorStat1LocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(40)] 
		[RED("armorStat2LocKey")] 
		public CName ArmorStat2LocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(41)] 
		[RED("armorStat3LocKey")] 
		public CName ArmorStat3LocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(42)] 
		[RED("armorPerkTitleLocKey")] 
		public CName ArmorPerkTitleLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(43)] 
		[RED("armorPerk1IconsName")] 
		public CName ArmorPerk1IconsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(44)] 
		[RED("armorPerk1LocKey")] 
		public CName ArmorPerk1LocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public RipperdocBarTooltip()
		{
			StatsHolder = new inkWidgetReference();
			PerksHolder = new inkWidgetReference();
			CapacityDescription = new inkWidgetReference();
			ArmorDescription = new inkWidgetReference();
			ArmorReductionDescription = new inkTextWidgetReference();
			TitleHolder = new inkWidgetReference();
			TitleName = new inkTextWidgetReference();
			TitleTotalValue = new inkTextWidgetReference();
			TitleMaxValue = new inkTextWidgetReference();
			Stats1 = new inkWidgetReference();
			Stats1Name = new inkTextWidgetReference();
			Stats1Value = new inkTextWidgetReference();
			Stats2 = new inkWidgetReference();
			Stats2Name = new inkTextWidgetReference();
			Stats2Value = new inkTextWidgetReference();
			Stats3 = new inkWidgetReference();
			Stats3Name = new inkTextWidgetReference();
			Stats3Value = new inkTextWidgetReference();
			PerkTypeName = new inkTextWidgetReference();
			Perk1 = new inkWidgetReference();
			Perk1Icon = new inkImageWidgetReference();
			Perk1Name = new inkTextWidgetReference();
			Perk2 = new inkWidgetReference();
			Perk2Icon = new inkImageWidgetReference();
			Perk2Name = new inkTextWidgetReference();
			PerkTreeInput = new inkWidgetReference();
			PerkTreeIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
