using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnCircle : IParticleInitializer
	{
		[Ordinal(4)] [RED("innerRadius")] public CHandle<IEvaluatorFloat> InnerRadius { get; set; }
		[Ordinal(5)] [RED("outerRadius")] public CHandle<IEvaluatorFloat> OuterRadius { get; set; }
		[Ordinal(6)] [RED("surfaceOnly")] public CBool SurfaceOnly { get; set; }
		[Ordinal(7)] [RED("worldSpace")] public CBool WorldSpace { get; set; }
		[Ordinal(8)] [RED("spawnToLocal")] public CMatrix SpawnToLocal { get; set; }

		public CParticleInitializerSpawnCircle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
