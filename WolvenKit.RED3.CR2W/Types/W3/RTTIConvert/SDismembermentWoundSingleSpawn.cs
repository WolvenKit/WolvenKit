using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDismembermentWoundSingleSpawn : CVariable
	{
		[Ordinal(1)] [RED("spawnedEntity")] 		public CHandle<CEntityTemplate> SpawnedEntity { get; set;}

		[Ordinal(2)] [RED("spawnEntityBoneName")] 		public CName SpawnEntityBoneName { get; set;}

		[Ordinal(3)] [RED("spawnedEntityCurveName")] 		public CName SpawnedEntityCurveName { get; set;}

		[Ordinal(4)] [RED("droppedEquipmentTag")] 		public CName DroppedEquipmentTag { get; set;}

		[Ordinal(5)] [RED("soundEvents", 2,0)] 		public CArray<StringAnsi> SoundEvents { get; set;}

		[Ordinal(6)] [RED("despawnAlongWithBase")] 		public CBool DespawnAlongWithBase { get; set;}

		[Ordinal(7)] [RED("syncPose")] 		public CBool SyncPose { get; set;}

		[Ordinal(8)] [RED("fixBaseBonesHierarchyType")] 		public CEnum<EFixBonesHierarchyType> FixBaseBonesHierarchyType { get; set;}

		[Ordinal(9)] [RED("fixSpawnedBonesHierarchyType")] 		public CEnum<EFixBonesHierarchyType> FixSpawnedBonesHierarchyType { get; set;}

		[Ordinal(10)] [RED("effectsNames", 2,0)] 		public CArray<CName> EffectsNames { get; set;}

		[Ordinal(11)] [RED("additionalEffects", 2,0)] 		public CArray<SDismembermentEffect> AdditionalEffects { get; set;}

		public SDismembermentWoundSingleSpawn(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDismembermentWoundSingleSpawn(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}