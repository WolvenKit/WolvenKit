using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkateJump : CExplorationStateJump
	{
		[Ordinal(1)] [RED("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[Ordinal(2)] [RED("attacked")] 		public CBool Attacked { get; set;}

		[Ordinal(3)] [RED("attacktimeMin")] 		public CFloat AttacktimeMin { get; set;}

		[Ordinal(4)] [RED("attackVertSpeedMin")] 		public CFloat AttackVertSpeedMin { get; set;}

		[Ordinal(5)] [RED("attackVertSpeedImpulse")] 		public CFloat AttackVertSpeedImpulse { get; set;}

		public CExplorationStateSkateJump(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkateJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}