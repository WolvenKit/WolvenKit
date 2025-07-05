using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_Climb : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("verticalPosition")] 
		public Vector4 VerticalPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("horizontalPosition")] 
		public Vector4 HorizontalPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("toVerticalTime")] 
		public CFloat ToVerticalTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("verticalToHorizontalTime")] 
		public CFloat VerticalToHorizontalTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("frontEdgePosition")] 
		public Vector4 FrontEdgePosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("frontEdgeNormal")] 
		public Vector4 FrontEdgeNormal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("yawAngle")] 
		public CFloat YawAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("stateLength")] 
		public CFloat StateLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("climbType")] 
		public CInt32 ClimbType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimFeature_Climb()
		{
			VerticalPosition = new Vector4 { W = 1.000000F };
			HorizontalPosition = new Vector4 { W = 1.000000F };
			FrontEdgePosition = new Vector4 { W = 1.000000F };
			FrontEdgeNormal = new Vector4();
			ClimbType = -1;
			State = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
