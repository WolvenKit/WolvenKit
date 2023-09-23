using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryWeaponSlot : InventoryEquipmentSlot
	{
		[Ordinal(17)] 
		[RED("DamageIndicatorRef")] 
		public inkWidgetReference DamageIndicatorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("DPSRef")] 
		public inkWidgetReference DPSRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("DPSValueLabel")] 
		public inkTextWidgetReference DPSValueLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("DamageTypeIndicator")] 
		public CWeakHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get => GetPropertyValue<CWeakHandle<DamageTypeIndicator>>();
			set => SetPropertyValue<CWeakHandle<DamageTypeIndicator>>(value);
		}

		[Ordinal(21)] 
		[RED("IntroPlayed")] 
		public CBool IntroPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InventoryWeaponSlot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
