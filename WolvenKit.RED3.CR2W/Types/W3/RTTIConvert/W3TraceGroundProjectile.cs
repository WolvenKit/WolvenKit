using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TraceGroundProjectile : W3AdvancedProjectile
	{
		[Ordinal(1)] [RED("samplingFreq")] 		public CFloat SamplingFreq { get; set;}

		[Ordinal(2)] [RED("effectName")] 		public CName EffectName { get; set;}

		[Ordinal(3)] [RED("onRangedReachedDestroyAfter")] 		public CFloat OnRangedReachedDestroyAfter { get; set;}

		[Ordinal(4)] [RED("deactivateOnCollisionWithVictim")] 		public CBool DeactivateOnCollisionWithVictim { get; set;}

		[Ordinal(5)] [RED("comp")] 		public CHandle<CEffectDummyComponent> Comp { get; set;}

		public W3TraceGroundProjectile(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}