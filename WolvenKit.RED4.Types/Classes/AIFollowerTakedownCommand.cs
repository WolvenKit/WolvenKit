using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFollowerTakedownCommand : AIFollowerCommand
	{
		private gameEntityReference _targetRef;
		private CBool _approachBeforeTakedown;
		private CBool _doNotTeleportIfTargetIsVisible;
		private CWeakHandle<gameObject> _target;

		[Ordinal(5)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(6)] 
		[RED("approachBeforeTakedown")] 
		public CBool ApproachBeforeTakedown
		{
			get => GetProperty(ref _approachBeforeTakedown);
			set => SetProperty(ref _approachBeforeTakedown, value);
		}

		[Ordinal(7)] 
		[RED("doNotTeleportIfTargetIsVisible")] 
		public CBool DoNotTeleportIfTargetIsVisible
		{
			get => GetProperty(ref _doNotTeleportIfTargetIsVisible);
			set => SetProperty(ref _doNotTeleportIfTargetIsVisible, value);
		}

		[Ordinal(8)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}
