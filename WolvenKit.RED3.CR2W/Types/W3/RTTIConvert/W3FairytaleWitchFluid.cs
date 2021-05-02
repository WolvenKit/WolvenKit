using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FairytaleWitchFluid : CGameplayEntity
	{
		[Ordinal(1)] [RED("entitiesInRange", 2,0)] 		public CArray<CHandle<CGameplayEntity>> EntitiesInRange { get; set;}

		[Ordinal(2)] [RED("damageRadius")] 		public CFloat DamageRadius { get; set;}

		[Ordinal(3)] [RED("damageVal")] 		public CFloat DamageVal { get; set;}

		public W3FairytaleWitchFluid(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FairytaleWitchFluid(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}