using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PhotoModePlayerEntityComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("TS")] public CHandle<gameTransactionSystem> TS { get; set; }
		[Ordinal(1)]  [RED("availableItemTypesList")] public CArray<CEnum<gamedataItemType>> AvailableItemTypesList { get; set; }
		[Ordinal(2)]  [RED("availableItemsList")] public CArray<wCHandle<gameItemData>> AvailableItemsList { get; set; }
		[Ordinal(3)]  [RED("currentWeaponInSlot")] public gameItemID CurrentWeaponInSlot { get; set; }
		[Ordinal(4)]  [RED("fakePuppet")] public wCHandle<gamePuppet> FakePuppet { get; set; }
		[Ordinal(5)]  [RED("itemsLoadingTimeout")] public CFloat ItemsLoadingTimeout { get; set; }
		[Ordinal(6)]  [RED("loadingItems")] public CArray<gameItemID> LoadingItems { get; set; }
		[Ordinal(7)]  [RED("muzzleEffectEnabled")] public CBool MuzzleEffectEnabled { get; set; }
		[Ordinal(8)]  [RED("playerPuppet")] public wCHandle<PlayerPuppet> PlayerPuppet { get; set; }
		[Ordinal(9)]  [RED("swapHangunWeaponItemId")] public gameItemID SwapHangunWeaponItemId { get; set; }
		[Ordinal(10)]  [RED("swapMeeleWeaponItemId")] public gameItemID SwapMeeleWeaponItemId { get; set; }
		[Ordinal(11)]  [RED("swapRifleWeaponItemId")] public gameItemID SwapRifleWeaponItemId { get; set; }
		[Ordinal(12)]  [RED("swapShootgunWeaponItemId")] public gameItemID SwapShootgunWeaponItemId { get; set; }
		[Ordinal(13)]  [RED("usedWeaponItemId")] public gameItemID UsedWeaponItemId { get; set; }

		public PhotoModePlayerEntityComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
