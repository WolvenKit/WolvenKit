using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SParryInfo : CVariable
	{
		[Ordinal(0)] [RED("("attacker")] 		public CHandle<CActor> Attacker { get; set;}

		[Ordinal(0)] [RED("("target")] 		public CHandle<CActor> Target { get; set;}

		[Ordinal(0)] [RED("("targetToAttackerAngleAbs")] 		public CFloat TargetToAttackerAngleAbs { get; set;}

		[Ordinal(0)] [RED("("targetToAttackerDist")] 		public CFloat TargetToAttackerDist { get; set;}

		[Ordinal(0)] [RED("("attackSwingType")] 		public CEnum<EAttackSwingType> AttackSwingType { get; set;}

		[Ordinal(0)] [RED("("attackSwingDir")] 		public CEnum<EAttackSwingDirection> AttackSwingDir { get; set;}

		[Ordinal(0)] [RED("("attackActionName")] 		public CName AttackActionName { get; set;}

		[Ordinal(0)] [RED("("attackerWeaponId")] 		public SItemUniqueId AttackerWeaponId { get; set;}

		[Ordinal(0)] [RED("("canBeParried")] 		public CBool CanBeParried { get; set;}

		public SParryInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SParryInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}