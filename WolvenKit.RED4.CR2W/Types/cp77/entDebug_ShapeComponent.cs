using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDebug_ShapeComponent : entIVisualComponent
	{
		private CEnum<entDebug_ShapeType> _shape;
		private CFloat _radius;
		private CFloat _halfHeight;
		private CColor _color;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("shape")] 
		public CEnum<entDebug_ShapeType> Shape
		{
			get
			{
				if (_shape == null)
				{
					_shape = (CEnum<entDebug_ShapeType>) CR2WTypeManager.Create("entDebug_ShapeType", "shape", cr2w, this);
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("halfHeight")] 
		public CFloat HalfHeight
		{
			get
			{
				if (_halfHeight == null)
				{
					_halfHeight = (CFloat) CR2WTypeManager.Create("Float", "halfHeight", cr2w, this);
				}
				return _halfHeight;
			}
			set
			{
				if (_halfHeight == value)
				{
					return;
				}
				_halfHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public entDebug_ShapeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
