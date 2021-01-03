using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CrouchIndicatorGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("ActiveWeapon")] public gameSlotWeaponData ActiveWeapon { get; set; }
		[Ordinal(1)]  [RED("AllAmmoRef")] public inkTextWidgetReference AllAmmoRef { get; set; }
		[Ordinal(2)]  [RED("BBAmmoLooted")] public CUInt32 BBAmmoLooted { get; set; }
		[Ordinal(3)]  [RED("BBCurrentWeapon")] public CUInt32 BBCurrentWeapon { get; set; }
		[Ordinal(4)]  [RED("BBWeaponList")] public CUInt32 BBWeaponList { get; set; }
		[Ordinal(5)]  [RED("BufferedRosterData")] public CHandle<gameSlotDataHolder> BufferedRosterData { get; set; }
		[Ordinal(6)]  [RED("CurrentAmmoRef")] public inkTextWidgetReference CurrentAmmoRef { get; set; }
		[Ordinal(7)]  [RED("FireModes")] public CArray<inkImageWidgetReference> FireModes { get; set; }
		[Ordinal(8)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(9)]  [RED("LocomotionStateBlackboardId")] public CUInt32 LocomotionStateBlackboardId { get; set; }
		[Ordinal(10)]  [RED("Player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(11)]  [RED("PlayerSpawnedCallbackID")] public CUInt32 PlayerSpawnedCallbackID { get; set; }
		[Ordinal(12)]  [RED("UIBlackboard")] public CHandle<gameIBlackboard> UIBlackboard { get; set; }
		[Ordinal(13)]  [RED("UIStateBlackboardId")] public CUInt32 UIStateBlackboardId { get; set; }
		[Ordinal(14)]  [RED("VisionStateBlackboardId")] public CUInt32 VisionStateBlackboardId { get; set; }
		[Ordinal(15)]  [RED("WeaponAreas")] public CArray<CEnum<gamedataItemType>> WeaponAreas { get; set; }
		[Ordinal(16)]  [RED("WeaponMods")] public CArray<inkImageWidgetReference> WeaponMods { get; set; }
		[Ordinal(17)]  [RED("ammoHackedListenerId")] public CUInt32 AmmoHackedListenerId { get; set; }
		[Ordinal(18)]  [RED("ammoWrapper")] public inkWidgetReference AmmoWrapper { get; set; }
		[Ordinal(19)]  [RED("bbDefinition")] public CHandle<UIInteractionsDef> BbDefinition { get; set; }
		[Ordinal(20)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(21)]  [RED("bufferedAmmoId")] public CInt32 BufferedAmmoId { get; set; }
		[Ordinal(22)]  [RED("bufferedMaxAmmo")] public CInt32 BufferedMaxAmmo { get; set; }
		[Ordinal(23)]  [RED("container")] public inkWidgetReference Container { get; set; }
		[Ordinal(24)]  [RED("crouchIcon")] public inkImageWidgetReference CrouchIcon { get; set; }
		[Ordinal(25)]  [RED("damageTypeIndicator")] public wCHandle<DamageTypeIndicator> DamageTypeIndicator { get; set; }
		[Ordinal(26)]  [RED("damageTypeRef")] public inkWidgetReference DamageTypeRef { get; set; }
		[Ordinal(27)]  [RED("dataListenerId")] public CUInt32 DataListenerId { get; set; }
		[Ordinal(28)]  [RED("folded")] public CBool Folded { get; set; }
		[Ordinal(29)]  [RED("genderName")] public CName GenderName { get; set; }
		[Ordinal(30)]  [RED("hackingBlackboard")] public CHandle<gameIBlackboard> HackingBlackboard { get; set; }
		[Ordinal(31)]  [RED("modHolder")] public inkWidgetReference ModHolder { get; set; }
		[Ordinal(32)]  [RED("onMagazineAmmoCount")] public CUInt32 OnMagazineAmmoCount { get; set; }
		[Ordinal(33)]  [RED("outOfAmmoAnim")] public CHandle<inkanimProxy> OutOfAmmoAnim { get; set; }
		[Ordinal(34)]  [RED("smartLinkFirmwareOffline")] public inkCompoundWidgetReference SmartLinkFirmwareOffline { get; set; }
		[Ordinal(35)]  [RED("smartLinkFirmwareOnline")] public inkCompoundWidgetReference SmartLinkFirmwareOnline { get; set; }
		[Ordinal(36)]  [RED("transitionAnimProxy")] public CHandle<inkanimProxy> TransitionAnimProxy { get; set; }
		[Ordinal(37)]  [RED("warningMessageWraper")] public inkWidgetReference WarningMessageWraper { get; set; }
		[Ordinal(38)]  [RED("weaponBlackboard")] public CHandle<gameIBlackboard> WeaponBlackboard { get; set; }
		[Ordinal(39)]  [RED("weaponIcon")] public inkImageWidgetReference WeaponIcon { get; set; }
		[Ordinal(40)]  [RED("weaponItemData")] public InventoryItemData WeaponItemData { get; set; }
		[Ordinal(41)]  [RED("weaponName")] public inkTextWidgetReference WeaponName { get; set; }
		[Ordinal(42)]  [RED("weaponParamsListenerId")] public CUInt32 WeaponParamsListenerId { get; set; }

		public CrouchIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
