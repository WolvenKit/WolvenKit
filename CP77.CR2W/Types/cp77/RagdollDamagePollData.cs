using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RagdollDamagePollData : CVariable
	{
		[Ordinal(0)]  [RED("maxForceMagnitude")] public CFloat MaxForceMagnitude { get; set; }
		[Ordinal(1)]  [RED("maxImpulseMagnitude")] public CFloat MaxImpulseMagnitude { get; set; }
		[Ordinal(2)]  [RED("maxVelocityChange")] public CFloat MaxVelocityChange { get; set; }
		[Ordinal(3)]  [RED("maxZDiff")] public CFloat MaxZDiff { get; set; }
		[Ordinal(4)]  [RED("worldNormal")] public Vector4 WorldNormal { get; set; }
		[Ordinal(5)]  [RED("worldPosition")] public WorldPosition WorldPosition { get; set; }

		public RagdollDamagePollData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
