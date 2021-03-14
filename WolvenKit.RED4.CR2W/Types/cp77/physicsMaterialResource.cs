using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsMaterialResource : CResource
	{
		private CFloat _staticFriction;
		private CFloat _dynamicFriction;
		private CFloat _restitution;
		private CEnum<physicsMaterialFriction> _frictionMode;
		private CFloat _density;
		private physicsMaterialTags _tags;
		private CColor _color;
		private CUInt64 _id;

		[Ordinal(1)] 
		[RED("staticFriction")] 
		public CFloat StaticFriction
		{
			get
			{
				if (_staticFriction == null)
				{
					_staticFriction = (CFloat) CR2WTypeManager.Create("Float", "staticFriction", cr2w, this);
				}
				return _staticFriction;
			}
			set
			{
				if (_staticFriction == value)
				{
					return;
				}
				_staticFriction = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("dynamicFriction")] 
		public CFloat DynamicFriction
		{
			get
			{
				if (_dynamicFriction == null)
				{
					_dynamicFriction = (CFloat) CR2WTypeManager.Create("Float", "dynamicFriction", cr2w, this);
				}
				return _dynamicFriction;
			}
			set
			{
				if (_dynamicFriction == value)
				{
					return;
				}
				_dynamicFriction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("restitution")] 
		public CFloat Restitution
		{
			get
			{
				if (_restitution == null)
				{
					_restitution = (CFloat) CR2WTypeManager.Create("Float", "restitution", cr2w, this);
				}
				return _restitution;
			}
			set
			{
				if (_restitution == value)
				{
					return;
				}
				_restitution = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("frictionMode")] 
		public CEnum<physicsMaterialFriction> FrictionMode
		{
			get
			{
				if (_frictionMode == null)
				{
					_frictionMode = (CEnum<physicsMaterialFriction>) CR2WTypeManager.Create("physicsMaterialFriction", "frictionMode", cr2w, this);
				}
				return _frictionMode;
			}
			set
			{
				if (_frictionMode == value)
				{
					return;
				}
				_frictionMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("density")] 
		public CFloat Density
		{
			get
			{
				if (_density == null)
				{
					_density = (CFloat) CR2WTypeManager.Create("Float", "density", cr2w, this);
				}
				return _density;
			}
			set
			{
				if (_density == value)
				{
					return;
				}
				_density = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("tags")] 
		public physicsMaterialTags Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (physicsMaterialTags) CR2WTypeManager.Create("physicsMaterialTags", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt64) CR2WTypeManager.Create("Uint64", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public physicsMaterialResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
