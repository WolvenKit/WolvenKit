using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorDrag : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _dragCoefficient;
		private CFloat _scale;

		[Ordinal(4)] 
		[RED("dragCoefficient")] 
		public CHandle<IEvaluatorFloat> DragCoefficient
		{
			get => GetProperty(ref _dragCoefficient);
			set => SetProperty(ref _dragCoefficient, value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}
	}
}
