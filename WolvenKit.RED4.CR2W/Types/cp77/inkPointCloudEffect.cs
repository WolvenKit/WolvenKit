using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPointCloudEffect : inkIEffect
	{
		private CFloat _repeat;
		private CFloat _offsetX;
		private CFloat _offsetY;
		private CFloat _angle;
		private CFloat _fovScale;
		private CFloat _parallaxDepth;
		private CFloat _depthToOpacity;
		private CFloat _depthToBrightness;

		[Ordinal(2)] 
		[RED("repeat")] 
		public CFloat Repeat
		{
			get
			{
				if (_repeat == null)
				{
					_repeat = (CFloat) CR2WTypeManager.Create("Float", "repeat", cr2w, this);
				}
				return _repeat;
			}
			set
			{
				if (_repeat == value)
				{
					return;
				}
				_repeat = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("offsetX")] 
		public CFloat OffsetX
		{
			get
			{
				if (_offsetX == null)
				{
					_offsetX = (CFloat) CR2WTypeManager.Create("Float", "offsetX", cr2w, this);
				}
				return _offsetX;
			}
			set
			{
				if (_offsetX == value)
				{
					return;
				}
				_offsetX = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("offsetY")] 
		public CFloat OffsetY
		{
			get
			{
				if (_offsetY == null)
				{
					_offsetY = (CFloat) CR2WTypeManager.Create("Float", "offsetY", cr2w, this);
				}
				return _offsetY;
			}
			set
			{
				if (_offsetY == value)
				{
					return;
				}
				_offsetY = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("fovScale")] 
		public CFloat FovScale
		{
			get
			{
				if (_fovScale == null)
				{
					_fovScale = (CFloat) CR2WTypeManager.Create("Float", "fovScale", cr2w, this);
				}
				return _fovScale;
			}
			set
			{
				if (_fovScale == value)
				{
					return;
				}
				_fovScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("parallaxDepth")] 
		public CFloat ParallaxDepth
		{
			get
			{
				if (_parallaxDepth == null)
				{
					_parallaxDepth = (CFloat) CR2WTypeManager.Create("Float", "parallaxDepth", cr2w, this);
				}
				return _parallaxDepth;
			}
			set
			{
				if (_parallaxDepth == value)
				{
					return;
				}
				_parallaxDepth = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("depthToOpacity")] 
		public CFloat DepthToOpacity
		{
			get
			{
				if (_depthToOpacity == null)
				{
					_depthToOpacity = (CFloat) CR2WTypeManager.Create("Float", "depthToOpacity", cr2w, this);
				}
				return _depthToOpacity;
			}
			set
			{
				if (_depthToOpacity == value)
				{
					return;
				}
				_depthToOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("depthToBrightness")] 
		public CFloat DepthToBrightness
		{
			get
			{
				if (_depthToBrightness == null)
				{
					_depthToBrightness = (CFloat) CR2WTypeManager.Create("Float", "depthToBrightness", cr2w, this);
				}
				return _depthToBrightness;
			}
			set
			{
				if (_depthToBrightness == value)
				{
					return;
				}
				_depthToBrightness = value;
				PropertySet(this);
			}
		}

		public inkPointCloudEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
