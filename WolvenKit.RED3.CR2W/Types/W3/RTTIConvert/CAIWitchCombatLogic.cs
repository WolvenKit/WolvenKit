using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIWitchCombatLogic : CAIMonsterCombatLogic
	{
		[Ordinal(1)] [RED("Phase1")] 		public CBool Phase1 { get; set;}

		[Ordinal(2)] [RED("Phase2")] 		public CBool Phase2 { get; set;}

		[Ordinal(3)] [RED("PhaseReset")] 		public CBool PhaseReset { get; set;}

		[Ordinal(4)] [RED("AbilityHypnosis")] 		public CBool AbilityHypnosis { get; set;}

		public CAIWitchCombatLogic(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}