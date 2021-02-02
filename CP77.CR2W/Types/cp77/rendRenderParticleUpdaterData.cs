using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderParticleUpdaterData : CVariable
	{
		[Ordinal(0)]  [RED("data")] public DataBuffer Data { get; set; }
		[Ordinal(1)]  [RED("modifOffset")] public CUInt32 ModifOffset { get; set; }
		[Ordinal(2)]  [RED("animFrameInit")] public CArray<CFloat> AnimFrameInit { get; set; }
		[Ordinal(3)]  [RED("turbulenceNoiseInterval")] public CFloat TurbulenceNoiseInterval { get; set; }
		[Ordinal(4)]  [RED("turbulenceDuration")] public CFloat TurbulenceDuration { get; set; }
		[Ordinal(5)]  [RED("collisionMask")] public CUInt64 CollisionMask { get; set; }
		[Ordinal(6)]  [RED("collisionDynamicFriction")] public CFloat CollisionDynamicFriction { get; set; }
		[Ordinal(7)]  [RED("collisionStaticFriction")] public CFloat CollisionStaticFriction { get; set; }
		[Ordinal(8)]  [RED("collisionRestitution")] public CFloat CollisionRestitution { get; set; }
		[Ordinal(9)]  [RED("collisionVelocityDamp")] public CFloat CollisionVelocityDamp { get; set; }
		[Ordinal(10)]  [RED("collisionDisableGravity")] public CBool CollisionDisableGravity { get; set; }
		[Ordinal(11)]  [RED("collisionRadius")] public CFloat CollisionRadius { get; set; }
		[Ordinal(12)]  [RED("collisionEffectMask")] public CUInt32 CollisionEffectMask { get; set; }
		[Ordinal(13)]  [RED("maxCollisions")] public CUInt8 MaxCollisions { get; set; }
		[Ordinal(14)]  [RED("eventGenerate")] public CName EventGenerate { get; set; }
		[Ordinal(15)]  [RED("eventReceive")] public CName EventReceive { get; set; }
		[Ordinal(16)]  [RED("eventFrequency")] public CFloat EventFrequency { get; set; }
		[Ordinal(17)]  [RED("eventProbability")] public CFloat EventProbability { get; set; }
		[Ordinal(18)]  [RED("eventSpawnObject")] public CUInt8 EventSpawnObject { get; set; }
		[Ordinal(19)]  [RED("noiseType")] public CUInt8 NoiseType { get; set; }
		[Ordinal(20)]  [RED("randomPerChannel")] public CBool RandomPerChannel { get; set; }

		public rendRenderParticleUpdaterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
