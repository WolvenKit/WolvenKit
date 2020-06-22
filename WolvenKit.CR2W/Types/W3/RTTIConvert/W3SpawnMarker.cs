using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SpawnMarker : CGameplayEntity
	{
		[RED("spawnDelay")] 		public CFloat SpawnDelay { get; set;}

		[RED("destroyDelay")] 		public CFloat DestroyDelay { get; set;}

		[RED("entitiesToSpawn", 2,0)] 		public CArray<CHandle<CEntityTemplate>> EntitiesToSpawn { get; set;}

		[RED("spawnOnGround")] 		public CBool SpawnOnGround { get; set;}

		[RED("m_summonedEntityCmp")] 		public CHandle<W3SummonedEntityComponent> M_summonedEntityCmp { get; set;}

		public W3SpawnMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SpawnMarker(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}