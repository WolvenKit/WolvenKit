using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDismembermentWound : ISerializable
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("disabledOnAppearances", 2,0)] 		public CArray<CName> DisabledOnAppearances { get; set;}

		[RED("transform")] 		public EngineTransform Transform { get; set;}

		[RED("excludeTag")] 		public CName ExcludeTag { get; set;}

		[RED("fillMesh")] 		public CHandle<CMesh> FillMesh { get; set;}

		[RED("singleSpawnArray", 2,0)] 		public CArray<SDismembermentWoundSingleSpawn> SingleSpawnArray { get; set;}

		[RED("particles")] 		public CSoft<CParticleSystem> Particles { get; set;}

		[RED("attachedParticles")] 		public CSoft<CParticleSystem> AttachedParticles { get; set;}

		[RED("isExplosionWound")] 		public CBool IsExplosionWound { get; set;}

		[RED("isFrostWound")] 		public CBool IsFrostWound { get; set;}

		[RED("decal")] 		public SDismembermentWoundDecal Decal { get; set;}

		[RED("mainEntityCurveName")] 		public CName MainEntityCurveName { get; set;}

		public CDismembermentWound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDismembermentWound(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}