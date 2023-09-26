using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryWideItemDisplay : InventoryItemDisplay
	{
		[Ordinal(24)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("rarityBackground")] 
		public inkWidgetReference RarityBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("iconWrapper")] 
		public inkWidgetReference IconWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("damageIndicatorRef")] 
		public inkWidgetReference DamageIndicatorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("additionalInfoText")] 
		public inkTextWidgetReference AdditionalInfoText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("singleIconSize")] 
		public Vector2 SingleIconSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(32)] 
		[RED("damageTypeIndicator")] 
		public CWeakHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get => GetPropertyValue<CWeakHandle<DamageTypeIndicator>>();
			set => SetPropertyValue<CWeakHandle<DamageTypeIndicator>>(value);
		}

		[Ordinal(33)] 
		[RED("additionalInfoToShow")] 
		public CEnum<ItemAdditionalInfoType> AdditionalInfoToShow
		{
			get => GetPropertyValue<CEnum<ItemAdditionalInfoType>>();
			set => SetPropertyValue<CEnum<ItemAdditionalInfoType>>(value);
		}

		public InventoryWideItemDisplay()
		{
			ItemNameText = new inkTextWidgetReference();
			RarityBackground = new inkWidgetReference();
			IconWrapper = new inkWidgetReference();
			StatsWrapper = new inkWidgetReference();
			DpsText = new inkTextWidgetReference();
			DamageIndicatorRef = new inkWidgetReference();
			AdditionalInfoText = new inkTextWidgetReference();
			SingleIconSize = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
