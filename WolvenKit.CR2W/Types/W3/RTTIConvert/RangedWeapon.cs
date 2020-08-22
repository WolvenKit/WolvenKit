using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class RangedWeapon : CItemEntity
	{
		[RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[RED("ownerPlayer")] 		public CHandle<CR4Player> OwnerPlayer { get; set;}

		[RED("ownerPlayerWitcher")] 		public CHandle<W3PlayerWitcher> OwnerPlayerWitcher { get; set;}

		[RED("isPlayer")] 		public CBool IsPlayer { get; set;}

		[RED("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[RED("previousAmmoItemName")] 		public CName PreviousAmmoItemName { get; set;}

		[RED("deployedEnt")] 		public CHandle<W3BoltProjectile> DeployedEnt { get; set;}

		[RED("isSettingOwnerOrientation")] 		public CBool IsSettingOwnerOrientation { get; set;}

		[RED("isDeployedEntAiming")] 		public CBool IsDeployedEntAiming { get; set;}

		[RED("isAimingWeapon")] 		public CBool IsAimingWeapon { get; set;}

		[RED("isShootingWeapon")] 		public CBool IsShootingWeapon { get; set;}

		[RED("isWeaponLoaded")] 		public CBool IsWeaponLoaded { get; set;}

		[RED("recoilLevel")] 		public CInt32 RecoilLevel { get; set;}

		[RED("setFullWeight")] 		public CBool SetFullWeight { get; set;}

		[RED("noSaveLockCombatAction")] 		public CInt32 NoSaveLockCombatAction { get; set;}

		[RED("performedDraw")] 		public CBool PerformedDraw { get; set;}

		[RED("shootingIsComplete")] 		public CBool ShootingIsComplete { get; set;}

		[RED("wasBLAxisReleased")] 		public CBool WasBLAxisReleased { get; set;}

		[RED("bLAxisWasReleased")] 		public CBool BLAxisWasReleased { get; set;}

		public RangedWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new RangedWeapon(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}