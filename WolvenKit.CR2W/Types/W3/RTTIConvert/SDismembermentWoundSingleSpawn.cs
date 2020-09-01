using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDismembermentWoundSingleSpawn : CVariable
	{
		[Ordinal(0)] [RED("("spawnedEntity")] 		public CHandle<CEntityTemplate> SpawnedEntity { get; set;}

		[Ordinal(0)] [RED("("spawnEntityBoneName")] 		public CName SpawnEntityBoneName { get; set;}

		[Ordinal(0)] [RED("("spawnedEntityCurveName")] 		public CName SpawnedEntityCurveName { get; set;}

		[Ordinal(0)] [RED("("droppedEquipmentTag")] 		public CName DroppedEquipmentTag { get; set;}

		[Ordinal(0)] [RED("("soundEvents", 2,0)] 		public CArray<StringAnsi> SoundEvents { get; set;}

		[Ordinal(0)] [RED("("despawnAlongWithBase")] 		public CBool DespawnAlongWithBase { get; set;}

		[Ordinal(0)] [RED("("syncPose")] 		public CBool SyncPose { get; set;}

		[Ordinal(0)] [RED("("fixBaseBonesHierarchyType")] 		public CEnum<EFixBonesHierarchyType> FixBaseBonesHierarchyType { get; set;}

		[Ordinal(0)] [RED("("fixSpawnedBonesHierarchyType")] 		public CEnum<EFixBonesHierarchyType> FixSpawnedBonesHierarchyType { get; set;}

		[Ordinal(0)] [RED("("effectsNames", 2,0)] 		public CArray<CName> EffectsNames { get; set;}

		[Ordinal(0)] [RED("("additionalEffects", 2,0)] 		public CArray<SDismembermentEffect> AdditionalEffects { get; set;}

		public SDismembermentWoundSingleSpawn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDismembermentWoundSingleSpawn(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}