using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDropProjectilesFromAboveDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(2)] [RED("activeOnAnimEvent")] 		public CName ActiveOnAnimEvent { get; set;}

		[Ordinal(3)] [RED("chanceToGuaranteePlayerHit")] 		public CFloat ChanceToGuaranteePlayerHit { get; set;}

		[Ordinal(4)] [RED("timeBetweenSpawn")] 		public CFloat TimeBetweenSpawn { get; set;}

		[Ordinal(5)] [RED("timeBetweenSpawnRandomizationPerc")] 		public CFloat TimeBetweenSpawnRandomizationPerc { get; set;}

		[Ordinal(6)] [RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[Ordinal(7)] [RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[Ordinal(8)] [RED("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		[Ordinal(9)] [RED("minYOffset")] 		public CFloat MinYOffset { get; set;}

		[Ordinal(10)] [RED("maxYOffset")] 		public CFloat MaxYOffset { get; set;}

		[Ordinal(11)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(12)] [RED("useOwnerAsTarget")] 		public CBool UseOwnerAsTarget { get; set;}

		public CBTTaskDropProjectilesFromAboveDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDropProjectilesFromAboveDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}