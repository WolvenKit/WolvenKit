using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_MoveTo : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("initialFwdVector")] 
		public Vector4 InitialFwdVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("targetPositionWs")] 
		public Vector4 TargetPositionWs
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("targetDirectionWs")] 
		public Vector4 TargetDirectionWs
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("timeToMove")] 
		public CFloat TimeToMove
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimFeature_MoveTo()
		{
			InitialFwdVector = new Vector4 { Y = 1.000000F };
			TargetPositionWs = new Vector4 { W = 1.000000F };
			TargetDirectionWs = new Vector4 { Y = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
