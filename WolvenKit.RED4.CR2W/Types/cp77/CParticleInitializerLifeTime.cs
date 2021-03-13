using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerLifeTime : IParticleInitializer
	{
		[Ordinal(4)] [RED("lifeTime")] public CHandle<IEvaluatorFloat> LifeTime { get; set; }

		public CParticleInitializerLifeTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
