using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIInjectCombatThreatCommand : AICombatRelatedCommand
	{
		private NodeRef _targetNodeRef;
		private gameEntityReference _targetPuppetRef;
		private CBool _dontForceHostileAttitude;
		private CFloat _duration;
		private CBool _isPersistent;

		[Ordinal(5)] 
		[RED("targetNodeRef")] 
		public NodeRef TargetNodeRef
		{
			get => GetProperty(ref _targetNodeRef);
			set => SetProperty(ref _targetNodeRef, value);
		}

		[Ordinal(6)] 
		[RED("targetPuppetRef")] 
		public gameEntityReference TargetPuppetRef
		{
			get => GetProperty(ref _targetPuppetRef);
			set => SetProperty(ref _targetPuppetRef, value);
		}

		[Ordinal(7)] 
		[RED("dontForceHostileAttitude")] 
		public CBool DontForceHostileAttitude
		{
			get => GetProperty(ref _dontForceHostileAttitude);
			set => SetProperty(ref _dontForceHostileAttitude, value);
		}

		[Ordinal(8)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(9)] 
		[RED("isPersistent")] 
		public CBool IsPersistent
		{
			get => GetProperty(ref _isPersistent);
			set => SetProperty(ref _isPersistent, value);
		}
	}
}
