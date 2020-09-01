using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTModifyAttackCount : IBehTreeTask
	{
		[Ordinal(0)] [RED("("combatDataStorage")] 		public CHandle<CExtendedAICombatStorage> CombatDataStorage { get; set;}

		[Ordinal(0)] [RED("("attackName")] 		public CName AttackName { get; set;}

		[Ordinal(0)] [RED("("resetAttackCount")] 		public CBool ResetAttackCount { get; set;}

		[Ordinal(0)] [RED("("incrementAttackCount")] 		public CBool IncrementAttackCount { get; set;}

		public CBTModifyAttackCount(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTModifyAttackCount(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}