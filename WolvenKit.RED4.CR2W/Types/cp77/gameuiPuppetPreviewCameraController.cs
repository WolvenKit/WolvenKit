using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreviewCameraController : CVariable
	{
		private CArray<gameuiPuppetPreviewCameraSetup> _cameraSetup;
		private CUInt32 _activeSetup;
		private CFloat _transitionDelay;

		[Ordinal(0)] 
		[RED("cameraSetup")] 
		public CArray<gameuiPuppetPreviewCameraSetup> CameraSetup
		{
			get
			{
				if (_cameraSetup == null)
				{
					_cameraSetup = (CArray<gameuiPuppetPreviewCameraSetup>) CR2WTypeManager.Create("array:gameuiPuppetPreviewCameraSetup", "cameraSetup", cr2w, this);
				}
				return _cameraSetup;
			}
			set
			{
				if (_cameraSetup == value)
				{
					return;
				}
				_cameraSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activeSetup")] 
		public CUInt32 ActiveSetup
		{
			get
			{
				if (_activeSetup == null)
				{
					_activeSetup = (CUInt32) CR2WTypeManager.Create("Uint32", "activeSetup", cr2w, this);
				}
				return _activeSetup;
			}
			set
			{
				if (_activeSetup == value)
				{
					return;
				}
				_activeSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("transitionDelay")] 
		public CFloat TransitionDelay
		{
			get
			{
				if (_transitionDelay == null)
				{
					_transitionDelay = (CFloat) CR2WTypeManager.Create("Float", "transitionDelay", cr2w, this);
				}
				return _transitionDelay;
			}
			set
			{
				if (_transitionDelay == value)
				{
					return;
				}
				_transitionDelay = value;
				PropertySet(this);
			}
		}

		public gameuiPuppetPreviewCameraController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
