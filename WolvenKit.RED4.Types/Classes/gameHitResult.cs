using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitResult : RedBaseClass
	{
		private Vector4 _hitPositionEnter;
		private Vector4 _hitPositionExit;
		private CFloat _enterDistanceFromOriginSq;

		[Ordinal(0)] 
		[RED("hitPositionEnter")] 
		public Vector4 HitPositionEnter
		{
			get => GetProperty(ref _hitPositionEnter);
			set => SetProperty(ref _hitPositionEnter, value);
		}

		[Ordinal(1)] 
		[RED("hitPositionExit")] 
		public Vector4 HitPositionExit
		{
			get => GetProperty(ref _hitPositionExit);
			set => SetProperty(ref _hitPositionExit, value);
		}

		[Ordinal(2)] 
		[RED("enterDistanceFromOriginSq")] 
		public CFloat EnterDistanceFromOriginSq
		{
			get => GetProperty(ref _enterDistanceFromOriginSq);
			set => SetProperty(ref _enterDistanceFromOriginSq, value);
		}
	}
}
