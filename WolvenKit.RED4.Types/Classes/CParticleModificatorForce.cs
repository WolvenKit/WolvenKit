using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorForce : IParticleModificator
	{
		private Vector3 _pivot;
		private CFloat _radius;
		private CHandle<IEvaluatorFloat> _scale;
		private CHandle<IEvaluatorVector> _damp;

		[Ordinal(4)] 
		[RED("pivot")] 
		public Vector3 Pivot
		{
			get => GetProperty(ref _pivot);
			set => SetProperty(ref _pivot, value);
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(6)] 
		[RED("scale")] 
		public CHandle<IEvaluatorFloat> Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(7)] 
		[RED("damp")] 
		public CHandle<IEvaluatorVector> Damp
		{
			get => GetProperty(ref _damp);
			set => SetProperty(ref _damp, value);
		}

		public CParticleModificatorForce()
		{
			_radius = 10.000000F;
		}
	}
}
