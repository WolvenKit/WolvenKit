using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLightSweepEffect : inkIEffect
	{
		private CFloat _positionX;
		private CFloat _positionY;
		private CFloat _angle;
		private CFloat _width;
		private CFloat _intensity;

		[Ordinal(2)] 
		[RED("positionX")] 
		public CFloat PositionX
		{
			get
			{
				if (_positionX == null)
				{
					_positionX = (CFloat) CR2WTypeManager.Create("Float", "positionX", cr2w, this);
				}
				return _positionX;
			}
			set
			{
				if (_positionX == value)
				{
					return;
				}
				_positionX = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("positionY")] 
		public CFloat PositionY
		{
			get
			{
				if (_positionY == null)
				{
					_positionY = (CFloat) CR2WTypeManager.Create("Float", "positionY", cr2w, this);
				}
				return _positionY;
			}
			set
			{
				if (_positionY == value)
				{
					return;
				}
				_positionY = value;
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get
			{
				if (_intensity == null)
				{
					_intensity = (CFloat) CR2WTypeManager.Create("Float", "intensity", cr2w, this);
				}
				return _intensity;
			}
			set
			{
				if (_intensity == value)
				{
					return;
				}
				_intensity = value;
				PropertySet(this);
			}
		}

		public inkLightSweepEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
