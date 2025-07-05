using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entImpactPointData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("worldPosition")] 
		public WorldPosition WorldPosition
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		[Ordinal(1)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("forceMagnitude")] 
		public CFloat ForceMagnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("impulseMagnitude")] 
		public CFloat ImpulseMagnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxForceMagnitude")] 
		public CFloat MaxForceMagnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("maxImpulseMagnitude")] 
		public CFloat MaxImpulseMagnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entImpactPointData()
		{
			WorldPosition = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() };
			WorldNormal = new Vector4 { W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
