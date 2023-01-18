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
			NodeTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			LocalSpaceTrajectoryStartPoint = new();
			LocalSpaceTrajectoryEndPoint = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
