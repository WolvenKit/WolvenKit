using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerLifeTime : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _lifeTime;

		[Ordinal(4)] 
		[RED("lifeTime")] 
		public CHandle<IEvaluatorFloat> LifeTime
		{
			get => GetProperty(ref _lifeTime);
			set => SetProperty(ref _lifeTime, value);
		}

		public CParticleInitializerLifeTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
