using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerAlpha : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _alpha;

		[Ordinal(4)] 
		[RED("alpha")] 
		public CHandle<IEvaluatorFloat> Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}

		public CParticleInitializerAlpha(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
