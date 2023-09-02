using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileFollowTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)] 
		[RED("startVel")] 
		public CFloat StartVel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("targetComponent")] 
		public CWeakHandle<entIPlacedComponent> TargetComponent
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(3)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("targetOffset")] 
		public Vector4 TargetOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameprojectileFollowTrajectoryParams()
		{
			TargetOffset = new Vector4 { W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
