using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryWideItemDisplay : InventoryItemDisplay
	{
		[Ordinal(21)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("rarityBackground")] 
		public inkWidgetReference RarityBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("iconWrapper")] 
		public inkWidgetReference IconWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("damageIndicatorRef")] 
		public inkWidgetReference DamageIndicatorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("additionalInfoText")] 
		public inkTextWidgetReference AdditionalInfoText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("singleIconSize")] 
		public Vector2 SingleIconSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(29)] 
		[RED("damageTypeIndicator")] 
		public CWeakHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get => GetPropertyValue<CWeakHandle<DamageTypeIndicator>>();
			set => SetPropertyValue<CWeakHandle<DamageTypeIndicator>>(value);
		}

		[Ordinal(30)] 
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
