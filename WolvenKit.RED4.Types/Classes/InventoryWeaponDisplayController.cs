using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryWeaponDisplayController : InventoryItemDisplayController
	{
		[Ordinal(90)] 
		[RED("weaponSpecyficModsRoot")] 
		public inkCompoundWidgetReference WeaponSpecyficModsRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(91)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(92)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(93)] 
		[RED("damageTypeIndicatorImage")] 
		public inkImageWidgetReference DamageTypeIndicatorImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(94)] 
		[RED("dpsWrapper")] 
		public inkWidgetReference DpsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(95)] 
		[RED("dpsValue")] 
		public inkTextWidgetReference DpsValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(96)] 
		[RED("silencerIcon")] 
		public inkWidgetReference SilencerIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(97)] 
		[RED("scopeIcon")] 
		public inkWidgetReference ScopeIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(98)] 
		[RED("weaponAttachmentsDisplay")] 
		public CArray<CWeakHandle<InventoryItemPartDisplay>> WeaponAttachmentsDisplay
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemPartDisplay>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemPartDisplay>>>(value);
		}

		public InventoryWeaponDisplayController()
		{
			WeaponSpecyficModsRoot = new();
			StatsWrapper = new();
			DpsText = new();
			DamageTypeIndicatorImage = new();
			DpsWrapper = new();
			DpsValue = new();
			SilencerIcon = new();
			ScopeIcon = new();
			WeaponAttachmentsDisplay = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
