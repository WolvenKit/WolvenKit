using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVirtualCameraComponent : entBaseCameraComponent
	{
		private CName _virtualCameraName;
		private CUInt32 _resolutionWidth;
		private CUInt32 _resolutionHeight;
		private CBool _drawBackground;
		private CBool _isEnabled;

		[Ordinal(10)] 
		[RED("virtualCameraName")] 
		public CName VirtualCameraName
		{
			get
			{
				if (_virtualCameraName == null)
				{
					_virtualCameraName = (CName) CR2WTypeManager.Create("CName", "virtualCameraName", cr2w, this);
				}
				return _virtualCameraName;
			}
			set
			{
				if (_virtualCameraName == value)
				{
					return;
				}
				_virtualCameraName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("resolutionWidth")] 
		public CUInt32 ResolutionWidth
		{
			get
			{
				if (_resolutionWidth == null)
				{
					_resolutionWidth = (CUInt32) CR2WTypeManager.Create("Uint32", "resolutionWidth", cr2w, this);
				}
				return _resolutionWidth;
			}
			set
			{
				if (_resolutionWidth == value)
				{
					return;
				}
				_resolutionWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("resolutionHeight")] 
		public CUInt32 ResolutionHeight
		{
			get
			{
				if (_resolutionHeight == null)
				{
					_resolutionHeight = (CUInt32) CR2WTypeManager.Create("Uint32", "resolutionHeight", cr2w, this);
				}
				return _resolutionHeight;
			}
			set
			{
				if (_resolutionHeight == value)
				{
					return;
				}
				_resolutionHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("drawBackground")] 
		public CBool DrawBackground
		{
			get
			{
				if (_drawBackground == null)
				{
					_drawBackground = (CBool) CR2WTypeManager.Create("Bool", "drawBackground", cr2w, this);
				}
				return _drawBackground;
			}
			set
			{
				if (_drawBackground == value)
				{
					return;
				}
				_drawBackground = value;
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

		public entVirtualCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
