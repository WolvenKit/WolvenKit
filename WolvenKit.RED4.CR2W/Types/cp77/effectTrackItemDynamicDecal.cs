using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDynamicDecal : effectTrackItem
	{
		private rRef<IMaterial> _material;
		private CFloat _width;
		private CFloat _height;
		private CFloat _fadeInTime;
		private CFloat _fadeOutTime;
		private CFloat _additionalRotation;
		private CBool _randomRotation;

		[Ordinal(3)] 
		[RED("material")] 
		public rRef<IMaterial> Material
		{
			get
			{
				if (_material == null)
				{
					_material = (rRef<IMaterial>) CR2WTypeManager.Create("rRef:IMaterial", "material", cr2w, this);
				}
				return _material;
			}
			set
			{
				if (_material == value)
				{
					return;
				}
				_material = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("width")] 
		public CFloat Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CFloat) CR2WTypeManager.Create("Float", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("height")] 
		public CFloat Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CFloat) CR2WTypeManager.Create("Float", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("fadeInTime")] 
		public CFloat FadeInTime
		{
			get
			{
				if (_fadeInTime == null)
				{
					_fadeInTime = (CFloat) CR2WTypeManager.Create("Float", "fadeInTime", cr2w, this);
				}
				return _fadeInTime;
			}
			set
			{
				if (_fadeInTime == value)
				{
					return;
				}
				_fadeInTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get
			{
				if (_fadeOutTime == null)
				{
					_fadeOutTime = (CFloat) CR2WTypeManager.Create("Float", "fadeOutTime", cr2w, this);
				}
				return _fadeOutTime;
			}
			set
			{
				if (_fadeOutTime == value)
				{
					return;
				}
				_fadeOutTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("additionalRotation")] 
		public CFloat AdditionalRotation
		{
			get
			{
				if (_additionalRotation == null)
				{
					_additionalRotation = (CFloat) CR2WTypeManager.Create("Float", "additionalRotation", cr2w, this);
				}
				return _additionalRotation;
			}
			set
			{
				if (_additionalRotation == value)
				{
					return;
				}
				_additionalRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("randomRotation")] 
		public CBool RandomRotation
		{
			get
			{
				if (_randomRotation == null)
				{
					_randomRotation = (CBool) CR2WTypeManager.Create("Bool", "randomRotation", cr2w, this);
				}
				return _randomRotation;
			}
			set
			{
				if (_randomRotation == value)
				{
					return;
				}
				_randomRotation = value;
				PropertySet(this);
			}
		}

		public effectTrackItemDynamicDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
