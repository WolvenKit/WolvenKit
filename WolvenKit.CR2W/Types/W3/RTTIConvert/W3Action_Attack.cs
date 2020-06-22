using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Action_Attack : W3DamageAction
	{
		[RED("weaponId")] 		public SItemUniqueId WeaponId { get; set;}

		[RED("crossbowId")] 		public SItemUniqueId CrossbowId { get; set;}

		[RED("attackName")] 		public CName AttackName { get; set;}

		[RED("attackTypeName")] 		public CName AttackTypeName { get; set;}

		[RED("isAttackReflected")] 		public CBool IsAttackReflected { get; set;}

		[RED("isParried")] 		public CBool IsParried { get; set;}

		[RED("isCountered")] 		public CBool IsCountered { get; set;}

		[RED("attackAnimName")] 		public CName AttackAnimName { get; set;}

		[RED("hitTime")] 		public CFloat HitTime { get; set;}

		[RED("weaponEntity")] 		public CHandle<CItemEntity> WeaponEntity { get; set;}

		[RED("weaponSlot")] 		public CName WeaponSlot { get; set;}

		[RED("boneIndex")] 		public CInt32 BoneIndex { get; set;}

		[RED("soundAttackType")] 		public CName SoundAttackType { get; set;}

		[RED("usedZeroStaminaPerk")] 		public CBool UsedZeroStaminaPerk { get; set;}

		[RED("applyBuffsIfParried")] 		public CBool ApplyBuffsIfParried { get; set;}

		public W3Action_Attack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Action_Attack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}