using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Spline : ISerializable
	{
		[Ordinal(0)] 
		[RED("points")] 
		public CArray<SplinePoint> Points
		{
			get => GetPropertyValue<CArray<SplinePoint>>();
			set => SetPropertyValue<CArray<SplinePoint>>(value);
		}

		[Ordinal(1)] 
		[RED("looped")] 
		public CBool Looped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("reversed")] 
		public CBool Reversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("hasDirection")] 
		public CBool HasDirection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public Spline()
		{
			Points = new();
			HasDirection = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
