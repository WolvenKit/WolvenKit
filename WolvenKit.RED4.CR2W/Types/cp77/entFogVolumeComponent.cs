using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entFogVolumeComponent : entIVisualComponent
	{
		private CFloat _densityFalloff;
		private CFloat _blendFalloff;
		private CFloat _densityFactor;
		private CColor _color;
		private CFloat _absorption;
		private Vector3 _size;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("densityFalloff")] 
		public CFloat DensityFalloff
		{
			get
			{
				if (_densityFalloff == null)
				{
					_densityFalloff = (CFloat) CR2WTypeManager.Create("Float", "densityFalloff", cr2w, this);
				}
				return _densityFalloff;
			}
			set
			{
				if (_densityFalloff == value)
				{
					return;
				}
				_densityFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("blendFalloff")] 
		public CFloat BlendFalloff
		{
			get
			{
				if (_blendFalloff == null)
				{
					_blendFalloff = (CFloat) CR2WTypeManager.Create("Float", "blendFalloff", cr2w, this);
				}
				return _blendFalloff;
			}
			set
			{
				if (_blendFalloff == value)
				{
					return;
				}
				_blendFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("densityFactor")] 
		public CFloat DensityFactor
		{
			get
			{
				if (_densityFactor == null)
				{
					_densityFactor = (CFloat) CR2WTypeManager.Create("Float", "densityFactor", cr2w, this);
				}
				return _densityFactor;
			}
			set
			{
				if (_densityFactor == value)
				{
					return;
				}
				_densityFactor = value;
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
		[RED("absorption")] 
		public CFloat Absorption
		{
			get
			{
				if (_absorption == null)
				{
					_absorption = (CFloat) CR2WTypeManager.Create("Float", "absorption", cr2w, this);
				}
				return _absorption;
			}
			set
			{
				if (_absorption == value)
				{
					return;
				}
				_absorption = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("size")] 
		public Vector3 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (Vector3) CR2WTypeManager.Create("Vector3", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		public entFogVolumeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
