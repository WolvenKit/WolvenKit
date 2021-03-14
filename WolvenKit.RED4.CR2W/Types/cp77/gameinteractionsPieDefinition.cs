using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsPieDefinition : gameinteractionsIShapeDefinition
	{
		private Vector4 _center;
		private CFloat _baseLength;
		private CFloat _halfExtentZ;
		private CFloat _radius;
		private CFloat _angle;

		[Ordinal(0)] 
		[RED("center")] 
		public Vector4 Center
		{
			get
			{
				if (_center == null)
				{
					_center = (Vector4) CR2WTypeManager.Create("Vector4", "center", cr2w, this);
				}
				return _center;
			}
			set
			{
				if (_center == value)
				{
					return;
				}
				_center = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("baseLength")] 
		public CFloat BaseLength
		{
			get
			{
				if (_baseLength == null)
				{
					_baseLength = (CFloat) CR2WTypeManager.Create("Float", "baseLength", cr2w, this);
				}
				return _baseLength;
			}
			set
			{
				if (_baseLength == value)
				{
					return;
				}
				_baseLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("halfExtentZ")] 
		public CFloat HalfExtentZ
		{
			get
			{
				if (_halfExtentZ == null)
				{
					_halfExtentZ = (CFloat) CR2WTypeManager.Create("Float", "halfExtentZ", cr2w, this);
				}
				return _halfExtentZ;
			}
			set
			{
				if (_halfExtentZ == value)
				{
					return;
				}
				_halfExtentZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get
			{
				if (_angle == null)
				{
					_angle = (CFloat) CR2WTypeManager.Create("Float", "angle", cr2w, this);
				}
				return _angle;
			}
			set
			{
				if (_angle == value)
				{
					return;
				}
				_angle = value;
				PropertySet(this);
			}
		}

		public gameinteractionsPieDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
