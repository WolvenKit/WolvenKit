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
			get
			{
				if (_nodeTransform == null)
				{
					_nodeTransform = (WorldTransform) CR2WTypeManager.Create("WorldTransform", "nodeTransform", cr2w, this);
				}
				return _nodeTransform;
			}
			set
			{
				if (_nodeTransform == value)
				{
					return;
				}
				_nodeTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("localSpaceTrajectoryStartPoint")] 
		public Vector3 LocalSpaceTrajectoryStartPoint
		{
			get
			{
				if (_localSpaceTrajectoryStartPoint == null)
				{
					_localSpaceTrajectoryStartPoint = (Vector3) CR2WTypeManager.Create("Vector3", "localSpaceTrajectoryStartPoint", cr2w, this);
				}
				return _localSpaceTrajectoryStartPoint;
			}
			set
			{
				if (_localSpaceTrajectoryStartPoint == value)
				{
					return;
				}
				_localSpaceTrajectoryStartPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localSpaceTrajectoryEndPoint")] 
		public Vector3 LocalSpaceTrajectoryEndPoint
		{
			get
			{
				if (_localSpaceTrajectoryEndPoint == null)
				{
					_localSpaceTrajectoryEndPoint = (Vector3) CR2WTypeManager.Create("Vector3", "localSpaceTrajectoryEndPoint", cr2w, this);
				}
				return _localSpaceTrajectoryEndPoint;
			}
			set
			{
				if (_localSpaceTrajectoryEndPoint == value)
				{
					return;
				}
				_localSpaceTrajectoryEndPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("smartObjectDefinition")] 
		public CHandle<gameSmartObjectDefinition> SmartObjectDefinition
		{
			get
			{
				if (_smartObjectDefinition == null)
				{
					_smartObjectDefinition = (CHandle<gameSmartObjectDefinition>) CR2WTypeManager.Create("handle:gameSmartObjectDefinition", "smartObjectDefinition", cr2w, this);
				}
				return _smartObjectDefinition;
			}
			set
			{
				if (_smartObjectDefinition == value)
				{
					return;
				}
				_smartObjectDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<worldOffMeshConnectionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<worldOffMeshConnectionType>) CR2WTypeManager.Create("worldOffMeshConnectionType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public worldOffMeshSmartObjectUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
