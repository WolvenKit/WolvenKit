using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnMultipleEntities3StateAttackDef : CBTTaskSpawnMultipleEntitiesAttackDef
	{
		[RED("delayActivationTime")] 		public CFloat DelayActivationTime { get; set;}

		[RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[RED("spawnInterval")] 		public CFloat SpawnInterval { get; set;}

		[RED("decreaseLoopTimePerFailedCreateEntity")] 		public CFloat DecreaseLoopTimePerFailedCreateEntity { get; set;}

		[RED("spawnAdditionalEntityOnTargetPos")] 		public CBool SpawnAdditionalEntityOnTargetPos { get; set;}

		public CBTTaskSpawnMultipleEntities3StateAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnMultipleEntities3StateAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}