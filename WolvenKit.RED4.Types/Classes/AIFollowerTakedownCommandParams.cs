using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFollowerTakedownCommandParams : questScriptedAICommandParams
	{
		private gameEntityReference _targetRef;
		private CBool _approachBeforeTakedown;
		private CBool _doNotTeleportIfTargetIsVisible;

		[Ordinal(0)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(1)] 
		[RED("approachBeforeTakedown")] 
		public CBool ApproachBeforeTakedown
		{
			get => GetProperty(ref _approachBeforeTakedown);
			set => SetProperty(ref _approachBeforeTakedown, value);
		}

		[Ordinal(2)] 
		[RED("doNotTeleportIfTargetIsVisible")] 
		public CBool DoNotTeleportIfTargetIsVisible
		{
			get => GetProperty(ref _doNotTeleportIfTargetIsVisible);
			set => SetProperty(ref _doNotTeleportIfTargetIsVisible, value);
		}
	}
}
