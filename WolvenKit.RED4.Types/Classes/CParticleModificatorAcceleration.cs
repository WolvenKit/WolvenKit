using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorAcceleration : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _direction;
		private CHandle<IEvaluatorFloat> _scale;
		private CBool _worldSpace;

		[Ordinal(4)] 
		[RED("direction")] 
		public CHandle<IEvaluatorVector> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CHandle<IEvaluatorFloat> Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(6)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetProperty(ref _worldSpace);
			set => SetProperty(ref _worldSpace, value);
		}
	}
}
