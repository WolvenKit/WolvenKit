using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workEquipInventoryWeaponAction : workIWorkspotItemAction
	{
		[Ordinal(0)] 
		[RED("weaponType")] 
		public CEnum<workWeaponType> WeaponType
		{
			get => GetPropertyValue<CEnum<workWeaponType>>();
			set => SetPropertyValue<CEnum<workWeaponType>>(value);
		}

		[Ordinal(1)] 
		[RED("keepEquippedAfterExit")] 
		public CBool KeepEquippedAfterExit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("fallbackItem")] 
		public TweakDBID FallbackItem
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("fallbackSlot")] 
		public TweakDBID FallbackSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public workEquipInventoryWeaponAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
