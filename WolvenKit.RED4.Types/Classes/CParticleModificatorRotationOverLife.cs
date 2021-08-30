using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorRotationOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _rotation;
		private CBool _modulate;

		[Ordinal(4)] 
		[RED("rotation")] 
		public CHandle<IEvaluatorFloat> Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetProperty(ref _modulate);
			set => SetProperty(ref _modulate, value);
		}

		public CParticleModificatorRotationOverLife()
		{
			_modulate = true;
		}
	}
}
