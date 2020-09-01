using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3IllusionSpawner : CGameplayEntity
	{
		[Ordinal(1)] [RED("("m_illusionTemplate")] 		public CHandle<CEntityTemplate> M_illusionTemplate { get; set;}

		[Ordinal(2)] [RED("("m_factOnDispelOverride")] 		public CString M_factOnDispelOverride { get; set;}

		[Ordinal(3)] [RED("("l_illusion")] 		public CHandle<CEntity> L_illusion { get; set;}

		[Ordinal(4)] [RED("("spawnedIllusion")] 		public CHandle<W3IllusionaryObstacle> SpawnedIllusion { get; set;}

		[Ordinal(5)] [RED("("m_discoveryOneliner")] 		public CEnum<EIllusionDiscoveredOneliner> M_discoveryOneliner { get; set;}

		[Ordinal(6)] [RED("("m_factOnDiscoveryOverride")] 		public CString M_factOnDiscoveryOverride { get; set;}

		[Ordinal(7)] [RED("("discoveryOnelinerTag")] 		public CString DiscoveryOnelinerTag { get; set;}

		[Ordinal(8)] [RED("("spawnedObstacleTags", 2,0)] 		public CArray<CName> SpawnedObstacleTags { get; set;}

		[Ordinal(9)] [RED("("m_wasDestroyed")] 		public CBool M_wasDestroyed { get; set;}

		public W3IllusionSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3IllusionSpawner(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}