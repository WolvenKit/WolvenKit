using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3IllusionSpawner : CGameplayEntity
	{
		[RED("m_illusionTemplate")] 		public CHandle<CEntityTemplate> M_illusionTemplate { get; set;}

		[RED("m_factOnDispelOverride")] 		public CString M_factOnDispelOverride { get; set;}

		[RED("m_discoveryOneliner")] 		public EIllusionDiscoveredOneliner M_discoveryOneliner { get; set;}

		[RED("m_factOnDiscoveryOverride")] 		public CString M_factOnDiscoveryOverride { get; set;}

		[RED("discoveryOnelinerTag")] 		public CString DiscoveryOnelinerTag { get; set;}

		[RED("spawnedObstacleTags", 2,0)] 		public CArray<CName> SpawnedObstacleTags { get; set;}

		public W3IllusionSpawner(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3IllusionSpawner(cr2w);

	}
}