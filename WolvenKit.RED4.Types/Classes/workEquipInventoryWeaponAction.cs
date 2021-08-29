using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workEquipInventoryWeaponAction : workIWorkspotItemAction
	{
		private CEnum<workWeaponType> _weaponType;
		private CBool _keepEquippedAfterExit;
		private TweakDBID _fallbackItem;
		private TweakDBID _fallbackSlot;

		[Ordinal(0)] 
		[RED("weaponType")] 
		public CEnum<workWeaponType> WeaponType
		{
			get => GetProperty(ref _weaponType);
			set => SetProperty(ref _weaponType, value);
		}

		[Ordinal(1)] 
		[RED("keepEquippedAfterExit")] 
		public CBool KeepEquippedAfterExit
		{
			get => GetProperty(ref _keepEquippedAfterExit);
			set => SetProperty(ref _keepEquippedAfterExit, value);
		}

		[Ordinal(2)] 
		[RED("fallbackItem")] 
		public TweakDBID FallbackItem
		{
			get => GetProperty(ref _fallbackItem);
			set => SetProperty(ref _fallbackItem, value);
		}

		[Ordinal(3)] 
		[RED("fallbackSlot")] 
		public TweakDBID FallbackSlot
		{
			get => GetProperty(ref _fallbackSlot);
			set => SetProperty(ref _fallbackSlot, value);
		}
	}
}
