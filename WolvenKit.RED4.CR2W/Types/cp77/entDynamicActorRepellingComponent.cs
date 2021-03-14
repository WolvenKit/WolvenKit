using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDynamicActorRepellingComponent : entIPlacedComponent
	{
		private CEnum<entRepellingType> _type;
		private CEnum<entRepellingShape> _shape;
		private CFloat _magnitude;
		private CFloat _bendIntensity;
		private CEnum<rendWindShapeAnchorPointVert> _anchorPointVert;
		private CEnum<rendWindShapeAnchorPointHorz> _anchorPointHorz;
		private CEnum<rendWindShapeAnchorPointDepth> _anchorPointDepth;
		private CFloat _radius;
		private CFloat _capsuleRadius;
		private CFloat _capsuleHeight;

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<entRepellingType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<entRepellingType>) CR2WTypeManager.Create("entRepellingType", "type", cr2w, this);
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

		[Ordinal(6)] 
		[RED("shape")] 
		public CEnum<entRepellingShape> Shape
		{
			get
			{
				if (_shape == null)
				{
					_shape = (CEnum<entRepellingShape>) CR2WTypeManager.Create("entRepellingShape", "shape", cr2w, this);
				}
				return _shape;
			}
			set
			{
				if (_shape == value)
				{
					return;
				}
				_shape = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("magnitude")] 
		public CFloat Magnitude
		{
			get
			{
				if (_magnitude == null)
				{
					_magnitude = (CFloat) CR2WTypeManager.Create("Float", "magnitude", cr2w, this);
				}
				return _magnitude;
			}
			set
			{
				if (_magnitude == value)
				{
					return;
				}
				_magnitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("bendIntensity")] 
		public CFloat BendIntensity
		{
			get
			{
				if (_bendIntensity == null)
				{
					_bendIntensity = (CFloat) CR2WTypeManager.Create("Float", "bendIntensity", cr2w, this);
				}
				return _bendIntensity;
			}
			set
			{
				if (_bendIntensity == value)
				{
					return;
				}
				_bendIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("anchorPointVert")] 
		public CEnum<rendWindShapeAnchorPointVert> AnchorPointVert
		{
			get
			{
				if (_anchorPointVert == null)
				{
					_anchorPointVert = (CEnum<rendWindShapeAnchorPointVert>) CR2WTypeManager.Create("rendWindShapeAnchorPointVert", "anchorPointVert", cr2w, this);
				}
				return _anchorPointVert;
			}
			set
			{
				if (_anchorPointVert == value)
				{
					return;
				}
				_anchorPointVert = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("anchorPointHorz")] 
		public CEnum<rendWindShapeAnchorPointHorz> AnchorPointHorz
		{
			get
			{
				if (_anchorPointHorz == null)
				{
					_anchorPointHorz = (CEnum<rendWindShapeAnchorPointHorz>) CR2WTypeManager.Create("rendWindShapeAnchorPointHorz", "anchorPointHorz", cr2w, this);
				}
				return _anchorPointHorz;
			}
			set
			{
				if (_anchorPointHorz == value)
				{
					return;
				}
				_anchorPointHorz = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("anchorPointDepth")] 
		public CEnum<rendWindShapeAnchorPointDepth> AnchorPointDepth
		{
			get
			{
				if (_anchorPointDepth == null)
				{
					_anchorPointDepth = (CEnum<rendWindShapeAnchorPointDepth>) CR2WTypeManager.Create("rendWindShapeAnchorPointDepth", "anchorPointDepth", cr2w, this);
				}
				return _anchorPointDepth;
			}
			set
			{
				if (_anchorPointDepth == value)
				{
					return;
				}
				_anchorPointDepth = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("capsuleRadius")] 
		public CFloat CapsuleRadius
		{
			get
			{
				if (_capsuleRadius == null)
				{
					_capsuleRadius = (CFloat) CR2WTypeManager.Create("Float", "capsuleRadius", cr2w, this);
				}
				return _capsuleRadius;
			}
			set
			{
				if (_capsuleRadius == value)
				{
					return;
				}
				_capsuleRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("capsuleHeight")] 
		public CFloat CapsuleHeight
		{
			get
			{
				if (_capsuleHeight == null)
				{
					_capsuleHeight = (CFloat) CR2WTypeManager.Create("Float", "capsuleHeight", cr2w, this);
				}
				return _capsuleHeight;
			}
			set
			{
				if (_capsuleHeight == value)
				{
					return;
				}
				_capsuleHeight = value;
				PropertySet(this);
			}
		}

		public entDynamicActorRepellingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
