using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPreAttackEventData : CVariable
	{
		[RED("attackName")] 		public CName AttackName { get; set;}

		[RED("weaponSlot")] 		public CName WeaponSlot { get; set;}

		[RED("hitReactionType")] 		public CInt32 HitReactionType { get; set;}

		[RED("rangeName")] 		public CName RangeName { get; set;}

		[RED("Damage_Friendly")] 		public CBool Damage_Friendly { get; set;}

		[RED("Damage_Neutral")] 		public CBool Damage_Neutral { get; set;}

		[RED("Damage_Hostile")] 		public CBool Damage_Hostile { get; set;}

		[RED("Can_Parry_Attack")] 		public CBool Can_Parry_Attack { get; set;}

		[RED("hitFX")] 		public CName HitFX { get; set;}

		[RED("hitBackFX")] 		public CName HitBackFX { get; set;}

		[RED("hitParriedFX")] 		public CName HitParriedFX { get; set;}

		[RED("hitBackParriedFX")] 		public CName HitBackParriedFX { get; set;}

		[RED("swingType")] 		public CInt32 SwingType { get; set;}

		[RED("swingDir")] 		public CInt32 SwingDir { get; set;}

		[RED("soundAttackType")] 		public CName SoundAttackType { get; set;}

		[RED("canBeDodged")] 		public CBool CanBeDodged { get; set;}

		[RED("cameraAnimOnMissedHit")] 		public CName CameraAnimOnMissedHit { get; set;}

		public CPreAttackEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPreAttackEventData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}