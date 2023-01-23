using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsBumpEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("side")] 
		public CEnum<gameinteractionsBumpSide> Side
		{
			get => GetPropertyValue<CEnum<gameinteractionsBumpSide>>();
			set => SetPropertyValue<CEnum<gameinteractionsBumpSide>>(value);
		}

		[Ordinal(1)] 
		[RED("sourceLocation")] 
		public CEnum<gameinteractionsBumpLocation> SourceLocation
		{
			get => GetPropertyValue<CEnum<gameinteractionsBumpLocation>>();
			set => SetPropertyValue<CEnum<gameinteractionsBumpLocation>>(value);
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("sourcePosition")] 
		public Vector4 SourcePosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("sourceSquaredDistance")] 
		public CFloat SourceSquaredDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("sourceSpeed")] 
		public CFloat SourceSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("sourceRadius")] 
		public CFloat SourceRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("vehicleEntityID")] 
		public entEntityID VehicleEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public gameinteractionsBumpEvent()
		{
			Direction = new();
			SourcePosition = new();
			SourceSquaredDistance = float.PositiveInfinity;
			SourceRadius = 0.400000F;
			VehicleEntityID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
