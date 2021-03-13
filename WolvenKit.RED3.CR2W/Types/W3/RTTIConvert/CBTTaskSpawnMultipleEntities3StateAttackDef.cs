using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnMultipleEntities3StateAttackDef : CBTTaskSpawnMultipleEntitiesAttackDef
	{
		[Ordinal(1)] [RED("delayActivationTime")] 		public CFloat DelayActivationTime { get; set;}

		[Ordinal(2)] [RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[Ordinal(3)] [RED("spawnInterval")] 		public CFloat SpawnInterval { get; set;}

		[Ordinal(4)] [RED("decreaseLoopTimePerFailedCreateEntity")] 		public CFloat DecreaseLoopTimePerFailedCreateEntity { get; set;}

		[Ordinal(5)] [RED("spawnAdditionalEntityOnTargetPos")] 		public CBool SpawnAdditionalEntityOnTargetPos { get; set;}

		public CBTTaskSpawnMultipleEntities3StateAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnMultipleEntities3StateAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}