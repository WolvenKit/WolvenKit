using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDropProjectilesFromAboveDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("activeOnAnimEvent")] 		public CName ActiveOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("chanceToGuaranteePlayerHit")] 		public CFloat ChanceToGuaranteePlayerHit { get; set;}

		[Ordinal(0)] [RED("timeBetweenSpawn")] 		public CFloat TimeBetweenSpawn { get; set;}

		[Ordinal(0)] [RED("timeBetweenSpawnRandomizationPerc")] 		public CFloat TimeBetweenSpawnRandomizationPerc { get; set;}

		[Ordinal(0)] [RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[Ordinal(0)] [RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[Ordinal(0)] [RED("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		[Ordinal(0)] [RED("minYOffset")] 		public CFloat MinYOffset { get; set;}

		[Ordinal(0)] [RED("maxYOffset")] 		public CFloat MaxYOffset { get; set;}

		[Ordinal(0)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(0)] [RED("useOwnerAsTarget")] 		public CBool UseOwnerAsTarget { get; set;}

		public CBTTaskDropProjectilesFromAboveDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDropProjectilesFromAboveDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}