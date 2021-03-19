using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerVelocitySpread : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _scale;
		private CBool _conserveMomentum;

		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorFloat> Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(5)] 
		[RED("conserveMomentum")] 
		public CBool ConserveMomentum
		{
			get => GetProperty(ref _conserveMomentum);
			set => SetProperty(ref _conserveMomentum, value);
		}

		public CParticleInitializerVelocitySpread(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
