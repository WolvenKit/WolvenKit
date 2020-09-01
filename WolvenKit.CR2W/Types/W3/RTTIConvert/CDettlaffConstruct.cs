using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDettlaffConstruct : CNewNPC
	{
		[Ordinal(0)] [RED("("numberOfHits")] 		public CInt32 NumberOfHits { get; set;}

		[Ordinal(0)] [RED("("destroyCalled")] 		public CBool DestroyCalled { get; set;}

		[Ordinal(0)] [RED("("percLife")] 		public CFloat PercLife { get; set;}

		[Ordinal(0)] [RED("("chunkLife")] 		public CFloat ChunkLife { get; set;}

		[Ordinal(0)] [RED("("healthBarPerc")] 		public CFloat HealthBarPerc { get; set;}

		[Ordinal(0)] [RED("("lastHitTimestamp")] 		public CFloat LastHitTimestamp { get; set;}

		[Ordinal(0)] [RED("("testedHitTimestamp")] 		public CFloat TestedHitTimestamp { get; set;}

		[Ordinal(0)] [RED("("l_temp")] 		public CFloat L_temp { get; set;}

		[Ordinal(0)] [RED("("timeBetweenHits")] 		public CFloat TimeBetweenHits { get; set;}

		[Ordinal(0)] [RED("("timeBetweenFireDamage")] 		public CFloat TimeBetweenFireDamage { get; set;}

		[Ordinal(0)] [RED("("baseStat")] 		public CEnum<EBaseCharacterStats> BaseStat { get; set;}

		[Ordinal(0)] [RED("("requiredHits")] 		public CInt32 RequiredHits { get; set;}

		[Ordinal(0)] [RED("("effectOnTakeDamage")] 		public CName EffectOnTakeDamage { get; set;}

		[Ordinal(0)] [RED("("timeToDestroy")] 		public CFloat TimeToDestroy { get; set;}

		public CDettlaffConstruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDettlaffConstruct(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}