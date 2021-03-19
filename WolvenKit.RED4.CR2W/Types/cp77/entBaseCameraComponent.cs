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
			get => GetProperty(ref _fov);
			set => SetProperty(ref _fov, value);
		}

		[Ordinal(6)] 
		[RED("zoom")] 
		public CFloat Zoom
		{
			get => GetProperty(ref _zoom);
			set => SetProperty(ref _zoom, value);
		}

		[Ordinal(7)] 
		[RED("nearPlaneOverride")] 
		public CFloat NearPlaneOverride
		{
			get => GetProperty(ref _nearPlaneOverride);
			set => SetProperty(ref _nearPlaneOverride, value);
		}

		[Ordinal(8)] 
		[RED("farPlaneOverride")] 
		public CFloat FarPlaneOverride
		{
			get => GetProperty(ref _farPlaneOverride);
			set => SetProperty(ref _farPlaneOverride, value);
		}

		[Ordinal(9)] 
		[RED("motionBlurScale")] 
		public CFloat MotionBlurScale
		{
			get => GetProperty(ref _motionBlurScale);
			set => SetProperty(ref _motionBlurScale, value);
		}

		public entBaseCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
