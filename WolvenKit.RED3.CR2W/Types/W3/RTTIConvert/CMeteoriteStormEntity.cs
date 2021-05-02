using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMeteoriteStormEntity : CGameplayEntity
	{
		[Ordinal(1)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(2)] [RED("timeBetweenSpawn")] 		public CFloat TimeBetweenSpawn { get; set;}

		[Ordinal(3)] [RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[Ordinal(4)] [RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[Ordinal(5)] [RED("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		[Ordinal(6)] [RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		[Ordinal(7)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		public CMeteoriteStormEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMeteoriteStormEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}