using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDismembermentWoundSingleSpawn : CVariable
	{
		[RED("spawnedEntity")] 		public CHandle<CEntityTemplate> SpawnedEntity { get; set;}

		[RED("spawnEntityBoneName")] 		public CName SpawnEntityBoneName { get; set;}

		[RED("spawnedEntityCurveName")] 		public CName SpawnedEntityCurveName { get; set;}

		[RED("droppedEquipmentTag")] 		public CName DroppedEquipmentTag { get; set;}

		[RED("soundEvents", 2,0)] 		public CArray<StringAnsi> SoundEvents { get; set;}

		[RED("despawnAlongWithBase")] 		public CBool DespawnAlongWithBase { get; set;}

		[RED("syncPose")] 		public CBool SyncPose { get; set;}

		[RED("fixBaseBonesHierarchyType")] 		public EFixBonesHierarchyType FixBaseBonesHierarchyType { get; set;}

		[RED("fixSpawnedBonesHierarchyType")] 		public EFixBonesHierarchyType FixSpawnedBonesHierarchyType { get; set;}

		[RED("effectsNames", 2,0)] 		public CArray<CName> EffectsNames { get; set;}

		[RED("additionalEffects", 2,0)] 		public CArray<SDismembermentEffect> AdditionalEffects { get; set;}

		public SDismembermentWoundSingleSpawn(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SDismembermentWoundSingleSpawn(cr2w);

	}
}