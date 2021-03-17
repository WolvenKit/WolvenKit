using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetingBehaviour : CVariable
	{
		private CEnum<ESensorDeviceWakeState> _initialWakeState;
		private CBool _canRotate;
		private CFloat _lostTargetLookAtTime;
		private CFloat _lostTargetSearchTime;

		[Ordinal(0)] 
		[RED("initialWakeState")] 
		public CEnum<ESensorDeviceWakeState> InitialWakeState
		{
			get => GetProperty(ref _initialWakeState);
			set => SetProperty(ref _initialWakeState, value);
		}

		[Ordinal(1)] 
		[RED("canRotate")] 
		public CBool CanRotate
		{
			get => GetProperty(ref _canRotate);
			set => SetProperty(ref _canRotate, value);
		}

		[Ordinal(2)] 
		[RED("lostTargetLookAtTime")] 
		public CFloat LostTargetLookAtTime
		{
			get => GetProperty(ref _lostTargetLookAtTime);
			set => SetProperty(ref _lostTargetLookAtTime, value);
		}

		[Ordinal(3)] 
		[RED("lostTargetSearchTime")] 
		public CFloat LostTargetSearchTime
		{
			get => GetProperty(ref _lostTargetSearchTime);
			set => SetProperty(ref _lostTargetSearchTime, value);
		}

		public TargetingBehaviour(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
