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
		[Ordinal(0)] [RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(0)] [RED("ownerPlayer")] 		public CHandle<CR4Player> OwnerPlayer { get; set;}

		[Ordinal(0)] [RED("ownerPlayerWitcher")] 		public CHandle<W3PlayerWitcher> OwnerPlayerWitcher { get; set;}

		[Ordinal(0)] [RED("isPlayer")] 		public CBool IsPlayer { get; set;}

		[Ordinal(0)] [RED("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[Ordinal(0)] [RED("previousAmmoItemName")] 		public CName PreviousAmmoItemName { get; set;}

		[Ordinal(0)] [RED("deployedEnt")] 		public CHandle<W3BoltProjectile> DeployedEnt { get; set;}

		[Ordinal(0)] [RED("isSettingOwnerOrientation")] 		public CBool IsSettingOwnerOrientation { get; set;}

		[Ordinal(0)] [RED("isDeployedEntAiming")] 		public CBool IsDeployedEntAiming { get; set;}

		[Ordinal(0)] [RED("isAimingWeapon")] 		public CBool IsAimingWeapon { get; set;}

		[Ordinal(0)] [RED("isShootingWeapon")] 		public CBool IsShootingWeapon { get; set;}

		[Ordinal(0)] [RED("isWeaponLoaded")] 		public CBool IsWeaponLoaded { get; set;}

		[Ordinal(0)] [RED("recoilLevel")] 		public CInt32 RecoilLevel { get; set;}

		[Ordinal(0)] [RED("setFullWeight")] 		public CBool SetFullWeight { get; set;}

		[Ordinal(0)] [RED("noSaveLockCombatAction")] 		public CInt32 NoSaveLockCombatAction { get; set;}

		[Ordinal(0)] [RED("performedDraw")] 		public CBool PerformedDraw { get; set;}

		[Ordinal(0)] [RED("shootingIsComplete")] 		public CBool ShootingIsComplete { get; set;}

		[Ordinal(0)] [RED("wasBLAxisReleased")] 		public CBool WasBLAxisReleased { get; set;}

		[Ordinal(0)] [RED("bLAxisWasReleased")] 		public CBool BLAxisWasReleased { get; set;}

		public RangedWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new RangedWeapon(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}