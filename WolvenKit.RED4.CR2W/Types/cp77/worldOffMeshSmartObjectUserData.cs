using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshSmartObjectUserData : worldOffMeshUserData
	{
		private WorldTransform _nodeTransform;
		private Vector3 _localSpaceTrajectoryStartPoint;
		private Vector3 _localSpaceTrajectoryEndPoint;
		private CHandle<gameSmartObjectDefinition> _smartObjectDefinition;
		private CEnum<worldOffMeshConnectionType> _type;

		[Ordinal(0)] 
		[RED("nodeTransform")] 
		public WorldTransform NodeTransform
		{
			get => GetProperty(ref _nodeTransform);
			set => SetProperty(ref _nodeTransform, value);
		}

		[Ordinal(1)] 
		[RED("localSpaceTrajectoryStartPoint")] 
		public Vector3 LocalSpaceTrajectoryStartPoint
		{
			get => GetProperty(ref _localSpaceTrajectoryStartPoint);
			set => SetProperty(ref _localSpaceTrajectoryStartPoint, value);
		}

		[Ordinal(2)] 
		[RED("localSpaceTrajectoryEndPoint")] 
		public Vector3 LocalSpaceTrajectoryEndPoint
		{
			get => GetProperty(ref _localSpaceTrajectoryEndPoint);
			set => SetProperty(ref _localSpaceTrajectoryEndPoint, value);
		}

		[Ordinal(3)] 
		[RED("smartObjectDefinition")] 
		public CHandle<gameSmartObjectDefinition> SmartObjectDefinition
		{
			get => GetProperty(ref _smartObjectDefinition);
			set => SetProperty(ref _smartObjectDefinition, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<worldOffMeshConnectionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public worldOffMeshSmartObjectUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
