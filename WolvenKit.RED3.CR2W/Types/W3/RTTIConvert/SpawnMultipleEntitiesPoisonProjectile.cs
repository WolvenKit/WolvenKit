using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SpawnMultipleEntitiesPoisonProjectile : PoisonProjectile
	{
		[Ordinal(1)] [RED("numberOfSpawns")] 		public CInt32 NumberOfSpawns { get; set;}

		[Ordinal(2)] [RED("minDistFromTarget")] 		public CInt32 MinDistFromTarget { get; set;}

		[Ordinal(3)] [RED("maxDistFromTarget")] 		public CInt32 MaxDistFromTarget { get; set;}

		public SpawnMultipleEntitiesPoisonProjectile(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}