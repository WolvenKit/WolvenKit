using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTModifyAttackCount : IBehTreeTask
	{
		[Ordinal(1)] [RED("combatDataStorage")] 		public CHandle<CExtendedAICombatStorage> CombatDataStorage { get; set;}

		[Ordinal(2)] [RED("attackName")] 		public CName AttackName { get; set;}

		[Ordinal(3)] [RED("resetAttackCount")] 		public CBool ResetAttackCount { get; set;}

		[Ordinal(4)] [RED("incrementAttackCount")] 		public CBool IncrementAttackCount { get; set;}

		public CBTModifyAttackCount(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}