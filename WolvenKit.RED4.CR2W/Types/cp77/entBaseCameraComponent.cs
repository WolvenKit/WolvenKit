using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entBaseCameraComponent : entIPlacedComponent
	{
		private CFloat _fov;
		private CFloat _zoom;
		private CFloat _nearPlaneOverride;
		private CFloat _farPlaneOverride;
		private CFloat _motionBlurScale;

		[Ordinal(5)] 
		[RED("fov")] 
		public CFloat Fov
		{
			get
			{
				if (_fov == null)
				{
					_fov = (CFloat) CR2WTypeManager.Create("Float", "fov", cr2w, this);
				}
				return _fov;
			}
			set
			{
				if (_fov == value)
				{
					return;
				}
				_fov = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("zoom")] 
		public CFloat Zoom
		{
			get
			{
				if (_zoom == null)
				{
					_zoom = (CFloat) CR2WTypeManager.Create("Float", "zoom", cr2w, this);
				}
				return _zoom;
			}
			set
			{
				if (_zoom == value)
				{
					return;
				}
				_zoom = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("nearPlaneOverride")] 
		public CFloat NearPlaneOverride
		{
			get
			{
				if (_nearPlaneOverride == null)
				{
					_nearPlaneOverride = (CFloat) CR2WTypeManager.Create("Float", "nearPlaneOverride", cr2w, this);
				}
				return _nearPlaneOverride;
			}
			set
			{
				if (_nearPlaneOverride == value)
				{
					return;
				}
				_nearPlaneOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("farPlaneOverride")] 
		public CFloat FarPlaneOverride
		{
			get
			{
				if (_farPlaneOverride == null)
				{
					_farPlaneOverride = (CFloat) CR2WTypeManager.Create("Float", "farPlaneOverride", cr2w, this);
				}
				return _farPlaneOverride;
			}
			set
			{
				if (_farPlaneOverride == value)
				{
					return;
				}
				_farPlaneOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("motionBlurScale")] 
		public CFloat MotionBlurScale
		{
			get
			{
				if (_motionBlurScale == null)
				{
					_motionBlurScale = (CFloat) CR2WTypeManager.Create("Float", "motionBlurScale", cr2w, this);
				}
				return _motionBlurScale;
			}
			set
			{
				if (_motionBlurScale == value)
				{
					return;
				}
				_motionBlurScale = value;
				PropertySet(this);
			}
		}

		public entBaseCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
