using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCursorInterpolationOverrides : inkUserData
	{
		[Ordinal(0)] 
		[RED("minSpeed")] 
		public Vector2 MinSpeed
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("enterTime")] 
		public CFloat EnterTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameCursorInterpolationOverrides()
		{
			MinSpeed = new() { X = 0.350000F, Y = 0.350000F };
			EnterTime = 0.050000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
