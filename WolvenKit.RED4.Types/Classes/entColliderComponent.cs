using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entColliderComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("colliders")] 
		public CArray<CHandle<physicsICollider>> Colliders
		{
			get => GetPropertyValue<CArray<CHandle<physicsICollider>>>();
			set => SetPropertyValue<CArray<CHandle<physicsICollider>>>(value);
		}

		[Ordinal(6)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetPropertyValue<CEnum<physicsSimulationType>>();
			set => SetPropertyValue<CEnum<physicsSimulationType>>(value);
		}

		[Ordinal(7)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("useCCD")] 
		public CBool UseCCD
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("massOverride")] 
		public CFloat MassOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("volume")] 
		public CFloat Volume
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("inertia")] 
		public Vector3 Inertia
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(13)] 
		[RED("comOffset")] 
		public Transform ComOffset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(14)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(15)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("dynamicTrafficSetting")] 
		public TrafficGenDynamicTrafficSetting DynamicTrafficSetting
		{
			get => GetPropertyValue<TrafficGenDynamicTrafficSetting>();
			set => SetPropertyValue<TrafficGenDynamicTrafficSetting>(value);
		}

		public entColliderComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			Colliders = new();
			SimulationType = Enums.physicsSimulationType.Kinematic;
			MassOverride = -1.000000F;
			Inertia = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			ComOffset = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			IsEnabled = true;
			DynamicTrafficSetting = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
