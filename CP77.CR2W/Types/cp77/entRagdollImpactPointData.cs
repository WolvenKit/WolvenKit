using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entRagdollImpactPointData : CVariable
	{
		[Ordinal(0)] [RED("worldPosition")] public WorldPosition WorldPosition { get; set; }
		[Ordinal(1)] [RED("worldNormal")] public Vector4 WorldNormal { get; set; }
		[Ordinal(2)] [RED("forceMagnitude")] public CFloat ForceMagnitude { get; set; }
		[Ordinal(3)] [RED("impulseMagnitude")] public CFloat ImpulseMagnitude { get; set; }
		[Ordinal(4)] [RED("maxForceMagnitude")] public CFloat MaxForceMagnitude { get; set; }
		[Ordinal(5)] [RED("maxImpulseMagnitude")] public CFloat MaxImpulseMagnitude { get; set; }
		[Ordinal(6)] [RED("velocityChange")] public CFloat VelocityChange { get; set; }
		[Ordinal(7)] [RED("ragdollProxyActorIndex")] public CUInt32 RagdollProxyActorIndex { get; set; }
		[Ordinal(8)] [RED("otherProxyActorIndex")] public CUInt32 OtherProxyActorIndex { get; set; }

		public entRagdollImpactPointData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
