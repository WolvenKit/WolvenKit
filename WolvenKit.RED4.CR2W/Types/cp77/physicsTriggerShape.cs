using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsTriggerShape : CVariable
	{
		private CEnum<physicsShapeType> _shapeType;
		private Vector3 _shapeSize;
		private Transform _shapeLocalPose;

		[Ordinal(0)] 
		[RED("shapeType")] 
		public CEnum<physicsShapeType> ShapeType
		{
			get
			{
				if (_shapeType == null)
				{
					_shapeType = (CEnum<physicsShapeType>) CR2WTypeManager.Create("physicsShapeType", "shapeType", cr2w, this);
				}
				return _shapeType;
			}
			set
			{
				if (_shapeType == value)
				{
					return;
				}
				_shapeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("shapeSize")] 
		public Vector3 ShapeSize
		{
			get
			{
				if (_shapeSize == null)
				{
					_shapeSize = (Vector3) CR2WTypeManager.Create("Vector3", "shapeSize", cr2w, this);
				}
				return _shapeSize;
			}
			set
			{
				if (_shapeSize == value)
				{
					return;
				}
				_shapeSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shapeLocalPose")] 
		public Transform ShapeLocalPose
		{
			get
			{
				if (_shapeLocalPose == null)
				{
					_shapeLocalPose = (Transform) CR2WTypeManager.Create("Transform", "shapeLocalPose", cr2w, this);
				}
				return _shapeLocalPose;
			}
			set
			{
				if (_shapeLocalPose == value)
				{
					return;
				}
				_shapeLocalPose = value;
				PropertySet(this);
			}
		}

		public physicsTriggerShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
