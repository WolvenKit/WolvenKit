using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDismembermentWound : ISerializable
	{
		[Ordinal(1)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(2)] [RED("disabledOnAppearances", 2,0)] 		public CArray<CName> DisabledOnAppearances { get; set;}

		[Ordinal(3)] [RED("transform")] 		public EngineTransform Transform { get; set;}

		[Ordinal(4)] [RED("excludeTag")] 		public CName ExcludeTag { get; set;}

		[Ordinal(5)] [RED("fillMesh")] 		public CHandle<CMesh> FillMesh { get; set;}

		[Ordinal(6)] [RED("singleSpawnArray", 2,0)] 		public CArray<SDismembermentWoundSingleSpawn> SingleSpawnArray { get; set;}

		[Ordinal(7)] [RED("particles")] 		public CSoft<CParticleSystem> Particles { get; set;}

		[Ordinal(8)] [RED("attachedParticles")] 		public CSoft<CParticleSystem> AttachedParticles { get; set;}

		[Ordinal(9)] [RED("isExplosionWound")] 		public CBool IsExplosionWound { get; set;}

		[Ordinal(10)] [RED("isFrostWound")] 		public CBool IsFrostWound { get; set;}

		[Ordinal(11)] [RED("decal")] 		public SDismembermentWoundDecal Decal { get; set;}

		[Ordinal(12)] [RED("mainEntityCurveName")] 		public CName MainEntityCurveName { get; set;}

		public CDismembermentWound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDismembermentWound(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}