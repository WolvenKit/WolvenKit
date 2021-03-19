using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorRotationRateOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _rotationRate;
		private CBool _modulate;

		[Ordinal(4)] 
		[RED("rotationRate")] 
		public CHandle<IEvaluatorFloat> RotationRate
		{
			get => GetProperty(ref _rotationRate);
			set => SetProperty(ref _rotationRate, value);
		}

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetProperty(ref _modulate);
			set => SetProperty(ref _modulate, value);
		}

		public CParticleModificatorRotationRateOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
