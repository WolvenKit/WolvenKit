using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3EredinIceSpike : W3DurationObstacle
	{
		[Ordinal(1)] [RED("("explodeAfter")] 		public CFloat ExplodeAfter { get; set;}

		[Ordinal(2)] [RED("("damageRadius")] 		public CFloat DamageRadius { get; set;}

		[Ordinal(3)] [RED("("damageVal")] 		public CFloat DamageVal { get; set;}

		[Ordinal(4)] [RED("("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[Ordinal(5)] [RED("("meshComp")] 		public CHandle<CMeshComponent> MeshComp { get; set;}

		[Ordinal(6)] [RED("("destructionComp")] 		public CHandle<CDestructionSystemComponent> DestructionComp { get; set;}

		[Ordinal(7)] [RED("("entitiesInRange", 2,0)] 		public CArray<CHandle<CGameplayEntity>> EntitiesInRange { get; set;}

		public W3EredinIceSpike(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3EredinIceSpike(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}