using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Terminal : InteractiveMasterDevice
	{
		private CHandle<ScriptableVirtualCameraViewComponent> _cameraFeed;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;

		[Ordinal(93)] 
		[RED("cameraFeed")] 
		public CHandle<ScriptableVirtualCameraViewComponent> CameraFeed
		{
			get
			{
				if (_cameraFeed == null)
				{
					_cameraFeed = (CHandle<ScriptableVirtualCameraViewComponent>) CR2WTypeManager.Create("handle:ScriptableVirtualCameraViewComponent", "cameraFeed", cr2w, this);
				}
				return _cameraFeed;
			}
			set
			{
				if (_cameraFeed == value)
				{
					return;
				}
				_cameraFeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get
			{
				if (_isShortGlitchActive == null)
				{
					_isShortGlitchActive = (CBool) CR2WTypeManager.Create("Bool", "isShortGlitchActive", cr2w, this);
				}
				return _isShortGlitchActive;
			}
			set
			{
				if (_isShortGlitchActive == value)
				{
					return;
				}
				_isShortGlitchActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get
			{
				if (_shortGlitchDelayID == null)
				{
					_shortGlitchDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "shortGlitchDelayID", cr2w, this);
				}
				return _shortGlitchDelayID;
			}
			set
			{
				if (_shortGlitchDelayID == value)
				{
					return;
				}
				_shortGlitchDelayID = value;
				PropertySet(this);
			}
		}

		public Terminal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
