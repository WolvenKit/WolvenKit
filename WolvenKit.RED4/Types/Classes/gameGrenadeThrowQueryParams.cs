using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGrenadeThrowQueryParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("requester")] 
		public CWeakHandle<gameObject> Requester
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("targetPositionProvider")] 
		public CHandle<entIPositionProvider> TargetPositionProvider
		{
			get => GetPropertyValue<CHandle<entIPositionProvider>>();
			set => SetPropertyValue<CHandle<entIPositionProvider>>(value);
		}

		[Ordinal(3)] 
		[RED("minRadius")] 
		public CFloat MinRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxRadius")] 
		public CFloat MaxRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("friendlyAvoidanceRadius")] 
		public CFloat FriendlyAvoidanceRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("throwAngleDegrees")] 
		public CFloat ThrowAngleDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("gravitySimulation")] 
		public CFloat GravitySimulation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("minTargetAngleDegrees")] 
		public CFloat MinTargetAngleDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("maxTargetAngleDegrees")] 
		public CFloat MaxTargetAngleDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameGrenadeThrowQueryParams()
		{
			ThrowAngleDegrees = -1.000000F;
			GravitySimulation = -9.800000F;
			MinTargetAngleDegrees = -180.000000F;
			MaxTargetAngleDegrees = 180.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
