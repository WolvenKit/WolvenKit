using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorVectorFieldAttractor : IParticleModificator
	{
		private CBool _inheritVelocity;
		private CBool _attract;
		private CBool _drag;
		private CHandle<IEvaluatorFloat> _restitution;

		[Ordinal(4)] 
		[RED("inheritVelocity")] 
		public CBool InheritVelocity
		{
			get => GetProperty(ref _inheritVelocity);
			set => SetProperty(ref _inheritVelocity, value);
		}

		[Ordinal(5)] 
		[RED("attract")] 
		public CBool Attract
		{
			get => GetProperty(ref _attract);
			set => SetProperty(ref _attract, value);
		}

		[Ordinal(6)] 
		[RED("drag")] 
		public CBool Drag
		{
			get => GetProperty(ref _drag);
			set => SetProperty(ref _drag, value);
		}

		[Ordinal(7)] 
		[RED("restitution")] 
		public CHandle<IEvaluatorFloat> Restitution
		{
			get => GetProperty(ref _restitution);
			set => SetProperty(ref _restitution, value);
		}
	}
}
