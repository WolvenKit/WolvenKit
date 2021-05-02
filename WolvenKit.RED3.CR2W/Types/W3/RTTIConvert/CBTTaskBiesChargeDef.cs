using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBiesChargeDef : CBTTask3StateAttackDef
	{
		[Ordinal(1)] [RED("endStuck")] 		public CEnum<EAttackType> EndStuck { get; set;}

		[Ordinal(2)] [RED("endHit")] 		public CEnum<EAttackType> EndHit { get; set;}

		[Ordinal(3)] [RED("stuckTime")] 		public CFloat StuckTime { get; set;}

		public CBTTaskBiesChargeDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}