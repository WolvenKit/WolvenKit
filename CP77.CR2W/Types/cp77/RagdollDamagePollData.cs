using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RagdollDamagePollData : CVariable
	{
		[Ordinal(0)] [RED("worldPosition")] public WorldPosition WorldPosition { get; set; }
		[Ordinal(1)] [RED("worldNormal")] public Vector4 WorldNormal { get; set; }
		[Ordinal(2)] [RED("maxForceMagnitude")] public CFloat MaxForceMagnitude { get; set; }
		[Ordinal(3)] [RED("maxImpulseMagnitude")] public CFloat MaxImpulseMagnitude { get; set; }
		[Ordinal(4)] [RED("maxVelocityChange")] public CFloat MaxVelocityChange { get; set; }
		[Ordinal(5)] [RED("maxZDiff")] public CFloat MaxZDiff { get; set; }

		public RagdollDamagePollData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
