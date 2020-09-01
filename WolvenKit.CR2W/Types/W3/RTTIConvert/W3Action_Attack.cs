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
		[Ordinal(0)] [RED("("weaponId")] 		public SItemUniqueId WeaponId { get; set;}

		[Ordinal(0)] [RED("("crossbowId")] 		public SItemUniqueId CrossbowId { get; set;}

		[Ordinal(0)] [RED("("attackName")] 		public CName AttackName { get; set;}

		[Ordinal(0)] [RED("("attackTypeName")] 		public CName AttackTypeName { get; set;}

		[Ordinal(0)] [RED("("isAttackReflected")] 		public CBool IsAttackReflected { get; set;}

		[Ordinal(0)] [RED("("isParried")] 		public CBool IsParried { get; set;}

		[Ordinal(0)] [RED("("isCountered")] 		public CBool IsCountered { get; set;}

		[Ordinal(0)] [RED("("attackAnimName")] 		public CName AttackAnimName { get; set;}

		[Ordinal(0)] [RED("("hitTime")] 		public CFloat HitTime { get; set;}

		[Ordinal(0)] [RED("("weaponEntity")] 		public CHandle<CItemEntity> WeaponEntity { get; set;}

		[Ordinal(0)] [RED("("weaponSlot")] 		public CName WeaponSlot { get; set;}

		[Ordinal(0)] [RED("("boneIndex")] 		public CInt32 BoneIndex { get; set;}

		[Ordinal(0)] [RED("("soundAttackType")] 		public CName SoundAttackType { get; set;}

		[Ordinal(0)] [RED("("usedZeroStaminaPerk")] 		public CBool UsedZeroStaminaPerk { get; set;}

		[Ordinal(0)] [RED("("applyBuffsIfParried")] 		public CBool ApplyBuffsIfParried { get; set;}

		public W3Action_Attack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Action_Attack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}