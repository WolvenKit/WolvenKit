using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hitPositionEnter")] 
		public Vector4 HitPositionEnter
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("hitPositionExit")] 
		public Vector4 HitPositionExit
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("enterDistanceFromOriginSq")] 
		public CFloat EnterDistanceFromOriginSq
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameHitResult()
		{
			HitPositionEnter = new();
			HitPositionExit = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
