using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiEntityPreviewCameraSettings : CVariable
	{
		private CBool _autoEnable;
		private CEnum<ERenderingMode> _renderingMode;
		private CFloat _panSpeed;
		private EulerAngles _rotationSpeed;
		private EulerAngles _rotationMin;
		private EulerAngles _rotationMax;
		private EulerAngles _rotationDefault;
		private CFloat _zoomSpeed;
		private CFloat _zoomMin;
		private CFloat _zoomMax;
		private CFloat _zoomDefault;

		[Ordinal(0)] 
		[RED("autoEnable")] 
		public CBool AutoEnable
		{
			get
			{
				if (_autoEnable == null)
				{
					_autoEnable = (CBool) CR2WTypeManager.Create("Bool", "autoEnable", cr2w, this);
				}
				return _autoEnable;
			}
			set
			{
				if (_autoEnable == value)
				{
					return;
				}
				_autoEnable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("renderingMode")] 
		public CEnum<ERenderingMode> RenderingMode
		{
			get
			{
				if (_renderingMode == null)
				{
					_renderingMode = (CEnum<ERenderingMode>) CR2WTypeManager.Create("ERenderingMode", "renderingMode", cr2w, this);
				}
				return _renderingMode;
			}
			set
			{
				if (_renderingMode == value)
				{
					return;
				}
				_renderingMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("panSpeed")] 
		public CFloat PanSpeed
		{
			get
			{
				if (_panSpeed == null)
				{
					_panSpeed = (CFloat) CR2WTypeManager.Create("Float", "panSpeed", cr2w, this);
				}
				return _panSpeed;
			}
			set
			{
				if (_panSpeed == value)
				{
					return;
				}
				_panSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rotationSpeed")] 
		public EulerAngles RotationSpeed
		{
			get
			{
				if (_rotationSpeed == null)
				{
					_rotationSpeed = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "rotationSpeed", cr2w, this);
				}
				return _rotationSpeed;
			}
			set
			{
				if (_rotationSpeed == value)
				{
					return;
				}
				_rotationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rotationMin")] 
		public EulerAngles RotationMin
		{
			get
			{
				if (_rotationMin == null)
				{
					_rotationMin = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "rotationMin", cr2w, this);
				}
				return _rotationMin;
			}
			set
			{
				if (_rotationMin == value)
				{
					return;
				}
				_rotationMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rotationMax")] 
		public EulerAngles RotationMax
		{
			get
			{
				if (_rotationMax == null)
				{
					_rotationMax = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "rotationMax", cr2w, this);
				}
				return _rotationMax;
			}
			set
			{
				if (_rotationMax == value)
				{
					return;
				}
				_rotationMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("rotationDefault")] 
		public EulerAngles RotationDefault
		{
			get
			{
				if (_rotationDefault == null)
				{
					_rotationDefault = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "rotationDefault", cr2w, this);
				}
				return _rotationDefault;
			}
			set
			{
				if (_rotationDefault == value)
				{
					return;
				}
				_rotationDefault = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("zoomSpeed")] 
		public CFloat ZoomSpeed
		{
			get
			{
				if (_zoomSpeed == null)
				{
					_zoomSpeed = (CFloat) CR2WTypeManager.Create("Float", "zoomSpeed", cr2w, this);
				}
				return _zoomSpeed;
			}
			set
			{
				if (_zoomSpeed == value)
				{
					return;
				}
				_zoomSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("zoomMin")] 
		public CFloat ZoomMin
		{
			get
			{
				if (_zoomMin == null)
				{
					_zoomMin = (CFloat) CR2WTypeManager.Create("Float", "zoomMin", cr2w, this);
				}
				return _zoomMin;
			}
			set
			{
				if (_zoomMin == value)
				{
					return;
				}
				_zoomMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("zoomMax")] 
		public CFloat ZoomMax
		{
			get
			{
				if (_zoomMax == null)
				{
					_zoomMax = (CFloat) CR2WTypeManager.Create("Float", "zoomMax", cr2w, this);
				}
				return _zoomMax;
			}
			set
			{
				if (_zoomMax == value)
				{
					return;
				}
				_zoomMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("zoomDefault")] 
		public CFloat ZoomDefault
		{
			get
			{
				if (_zoomDefault == null)
				{
					_zoomDefault = (CFloat) CR2WTypeManager.Create("Float", "zoomDefault", cr2w, this);
				}
				return _zoomDefault;
			}
			set
			{
				if (_zoomDefault == value)
				{
					return;
				}
				_zoomDefault = value;
				PropertySet(this);
			}
		}

		public gameuiEntityPreviewCameraSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
