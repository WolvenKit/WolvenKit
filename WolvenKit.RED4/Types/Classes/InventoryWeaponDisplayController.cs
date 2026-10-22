using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryWeaponDisplayController : InventoryItemDisplayController
	{
		[Ordinal(122)] 
		[RED("weaponSpecyficModsRoot")] 
		public inkCompoundWidgetReference WeaponSpecyficModsRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(123)] 
		[RED("silencerIcon")] 
		public inkWidgetReference SilencerIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(124)] 
		[RED("scopeIcon")] 
		public inkWidgetReference ScopeIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(125)] 
		[RED("ammoIcon")] 
		public inkImageWidgetReference AmmoIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(126)] 
		[RED("inactiveDualWieldIcon")] 
		public inkWidgetReference InactiveDualWieldIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(127)] 
		[RED("primaryWeaponOnlyEquippedIcon")] 
		public inkWidgetReference PrimaryWeaponOnlyEquippedIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(128)] 
		[RED("dualWieldPrimaryWeaponIcon")] 
		public inkWidgetReference DualWieldPrimaryWeaponIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(129)] 
		[RED("dualWieldSecondaryWeaponIcon")] 
		public inkWidgetReference DualWieldSecondaryWeaponIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(130)] 
		[RED("switchToPrimaryArrow")] 
		public inkWidgetReference SwitchToPrimaryArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(131)] 
		[RED("switchToSecondaryArrow")] 
		public inkWidgetReference SwitchToSecondaryArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(132)] 
		[RED("switchToPrimaryArrowController")] 
		public CWeakHandle<inkButtonController> SwitchToPrimaryArrowController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(133)] 
		[RED("switchToSecondaryArrowController")] 
		public CWeakHandle<inkButtonController> SwitchToSecondaryArrowController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(134)] 
		[RED("toggleToPrimary")] 
		public CBool ToggleToPrimary
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(135)] 
		[RED("toggleToSecondary")] 
		public CBool ToggleToSecondary
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(136)] 
		[RED("showArrows")] 
		public CBool ShowArrows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(137)] 
		[RED("canCycleWeapons")] 
		public CBool CanCycleWeapons
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(138)] 
		[RED("isHoveringArrow")] 
		public CBool IsHoveringArrow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InventoryWeaponDisplayController()
		{
			WeaponSpecyficModsRoot = new inkCompoundWidgetReference();
			SilencerIcon = new inkWidgetReference();
			ScopeIcon = new inkWidgetReference();
			AmmoIcon = new inkImageWidgetReference();
			InactiveDualWieldIcon = new inkWidgetReference();
			PrimaryWeaponOnlyEquippedIcon = new inkWidgetReference();
			DualWieldPrimaryWeaponIcon = new inkWidgetReference();
			DualWieldSecondaryWeaponIcon = new inkWidgetReference();
			SwitchToPrimaryArrow = new inkWidgetReference();
			SwitchToSecondaryArrow = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
