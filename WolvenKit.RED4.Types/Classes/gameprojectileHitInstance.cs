using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileHitInstance : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("traceResult")] 
		public physicsTraceResult TraceResult
		{
			get => GetPropertyValue<physicsTraceResult>();
			set => SetPropertyValue<physicsTraceResult>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("projectilePosition")] 
		public Vector4 ProjectilePosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("projectileSourcePosition")] 
		public Vector4 ProjectileSourcePosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("forward")] 
		public Vector4 Forward
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("velocity")] 
		public Vector4 Velocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("hitObject")] 
		public CWeakHandle<entEntity> HitObject
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(7)] 
		[RED("hitWeakspot")] 
		public CWeakHandle<gameWeakspotObject> HitWeakspot
		{
			get => GetPropertyValue<CWeakHandle<gameWeakspotObject>>();
			set => SetPropertyValue<CWeakHandle<gameWeakspotObject>>(value);
		}

		[Ordinal(8)] 
		[RED("hitRepresentationResult")] 
		public gameQueryResult HitRepresentationResult
		{
			get => GetPropertyValue<gameQueryResult>();
			set => SetPropertyValue<gameQueryResult>(value);
		}

		[Ordinal(9)] 
		[RED("numRicochetBounces")] 
		public CInt32 NumRicochetBounces
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("isWaterSurfaceImpact")] 
		public CBool IsWaterSurfaceImpact
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("hitThroughWaterSurface")] 
		public CBool HitThroughWaterSurface
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameprojectileHitInstance()
		{
			TraceResult = new() { Position = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity }, Normal = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity } };
			Position = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F };
			ProjectilePosition = new();
			ProjectileSourcePosition = new();
			Forward = new();
			Velocity = new();
			HitRepresentationResult = new() { HitShapes = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
