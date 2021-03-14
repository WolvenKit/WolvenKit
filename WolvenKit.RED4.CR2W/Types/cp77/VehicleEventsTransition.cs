using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleEventsTransition : VehicleTransition
	{
		private CBool _isCameraTogglePressed;
		private CFloat _cameraToggleHoldToResetTimeSeconds;

		[Ordinal(1)] 
		[RED("isCameraTogglePressed")] 
		public CBool IsCameraTogglePressed
		{
			get
			{
				if (_isCameraTogglePressed == null)
				{
					_isCameraTogglePressed = (CBool) CR2WTypeManager.Create("Bool", "isCameraTogglePressed", cr2w, this);
				}
				return _isCameraTogglePressed;
			}
			set
			{
				if (_isCameraTogglePressed == value)
				{
					return;
				}
				_isCameraTogglePressed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cameraToggleHoldToResetTimeSeconds")] 
		public CFloat CameraToggleHoldToResetTimeSeconds
		{
			get
			{
				if (_cameraToggleHoldToResetTimeSeconds == null)
				{
					_cameraToggleHoldToResetTimeSeconds = (CFloat) CR2WTypeManager.Create("Float", "cameraToggleHoldToResetTimeSeconds", cr2w, this);
				}
				return _cameraToggleHoldToResetTimeSeconds;
			}
			set
			{
				if (_cameraToggleHoldToResetTimeSeconds == value)
				{
					return;
				}
				_cameraToggleHoldToResetTimeSeconds = value;
				PropertySet(this);
			}
		}

		public VehicleEventsTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
