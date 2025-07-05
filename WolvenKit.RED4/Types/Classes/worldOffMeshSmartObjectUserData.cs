using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldOffMeshSmartObjectUserData : worldOffMeshUserData
	{
		[Ordinal(0)] 
		[RED("nodeTransform")] 
		public WorldTransform NodeTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(1)] 
		[RED("localSpaceTrajectoryStartPoint")] 
		public Vector3 LocalSpaceTrajectoryStartPoint
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("localSpaceTrajectoryEndPoint")] 
		public Vector3 LocalSpaceTrajectoryEndPoint
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("smartObjectDefinition")] 
		public CHandle<gameSmartObjectDefinition> SmartObjectDefinition
		{
			get => GetPropertyValue<CHandle<gameSmartObjectDefinition>>();
			set => SetPropertyValue<CHandle<gameSmartObjectDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<worldOffMeshConnectionType> Type
		{
			get => GetPropertyValue<CEnum<worldOffMeshConnectionType>>();
			set => SetPropertyValue<CEnum<worldOffMeshConnectionType>>(value);
		}

		public worldOffMeshSmartObjectUserData()
		{
			NodeTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			LocalSpaceTrajectoryStartPoint = new Vector3();
			LocalSpaceTrajectoryEndPoint = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
