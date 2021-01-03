using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnCircle : IParticleInitializer
	{
		[Ordinal(0)]  [RED("innerRadius")] public CHandle<IEvaluatorFloat> InnerRadius { get; set; }
		[Ordinal(1)]  [RED("outerRadius")] public CHandle<IEvaluatorFloat> OuterRadius { get; set; }
		[Ordinal(2)]  [RED("spawnToLocal")] public CMatrix SpawnToLocal { get; set; }
		[Ordinal(3)]  [RED("surfaceOnly")] public CBool SurfaceOnly { get; set; }
		[Ordinal(4)]  [RED("worldSpace")] public CBool WorldSpace { get; set; }

		public CParticleInitializerSpawnCircle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
