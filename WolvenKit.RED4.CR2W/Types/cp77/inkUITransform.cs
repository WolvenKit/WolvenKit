using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkUITransform : CVariable
	{
		private Vector2 _translation;
		private Vector2 _scale;
		private Vector2 _shear;
		private CFloat _rotation;

		[Ordinal(0)] 
		[RED("translation")] 
		public Vector2 Translation
		{
			get
			{
				if (_translation == null)
				{
					_translation = (Vector2) CR2WTypeManager.Create("Vector2", "translation", cr2w, this);
				}
				return _translation;
			}
			set
			{
				if (_translation == value)
				{
					return;
				}
				_translation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("scale")] 
		public Vector2 Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (Vector2) CR2WTypeManager.Create("Vector2", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shear")] 
		public Vector2 Shear
		{
			get
			{
				if (_shear == null)
				{
					_shear = (Vector2) CR2WTypeManager.Create("Vector2", "shear", cr2w, this);
				}
				return _shear;
			}
			set
			{
				if (_shear == value)
				{
					return;
				}
				_shear = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rotation")] 
		public CFloat Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (CFloat) CR2WTypeManager.Create("Float", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		public inkUITransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
