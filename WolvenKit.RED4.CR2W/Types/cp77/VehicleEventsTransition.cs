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
			get => GetProperty(ref _isCameraTogglePressed);
			set => SetProperty(ref _isCameraTogglePressed, value);
		}

		[Ordinal(2)] 
		[RED("cameraToggleHoldToResetTimeSeconds")] 
		public CFloat CameraToggleHoldToResetTimeSeconds
		{
			get => GetProperty(ref _cameraToggleHoldToResetTimeSeconds);
			set => SetProperty(ref _cameraToggleHoldToResetTimeSeconds, value);
		}

		public VehicleEventsTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
