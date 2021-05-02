using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBackgroundCombatDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CHandle<AIBackgroundCombatCommand> _command;
		private CBool _execute;
		private CArray<AIBackgroundCombatStep> _steps;
		private CInt32 _currentStep;
		private NodeRef _desiredCover;
		private CEnum<AICoverExposureMethod> _desiredCoverExposureMethod;
		private NodeRef _desiredDestination;
		private CBool _hasDesiredTarget;
		private gameEntityReference _desiredTarget;
		private CUInt64 _desiredCoverId;
		private CUInt64 _currentCoverId;
		private wCHandle<gameObject> _currentTarget;
		private CBool _canFireFromCover;
		private CBool _canFireOutOfCover;

		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AIBackgroundCombatCommand> Command
		{
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}

		[Ordinal(1)] 
		[RED("execute")] 
		public CBool Execute
		{
			get => GetProperty(ref _execute);
			set => SetProperty(ref _execute, value);
		}

		[Ordinal(2)] 
		[RED("steps")] 
		public CArray<AIBackgroundCombatStep> Steps
		{
			get => GetProperty(ref _steps);
			set => SetProperty(ref _steps, value);
		}

		[Ordinal(3)] 
		[RED("currentStep")] 
		public CInt32 CurrentStep
		{
			get => GetProperty(ref _currentStep);
			set => SetProperty(ref _currentStep, value);
		}

		[Ordinal(4)] 
		[RED("desiredCover")] 
		public NodeRef DesiredCover
		{
			get => GetProperty(ref _desiredCover);
			set => SetProperty(ref _desiredCover, value);
		}

		[Ordinal(5)] 
		[RED("desiredCoverExposureMethod")] 
		public CEnum<AICoverExposureMethod> DesiredCoverExposureMethod
		{
			get => GetProperty(ref _desiredCoverExposureMethod);
			set => SetProperty(ref _desiredCoverExposureMethod, value);
		}

		[Ordinal(6)] 
		[RED("desiredDestination")] 
		public NodeRef DesiredDestination
		{
			get => GetProperty(ref _desiredDestination);
			set => SetProperty(ref _desiredDestination, value);
		}

		[Ordinal(7)] 
		[RED("hasDesiredTarget")] 
		public CBool HasDesiredTarget
		{
			get => GetProperty(ref _hasDesiredTarget);
			set => SetProperty(ref _hasDesiredTarget, value);
		}

		[Ordinal(8)] 
		[RED("desiredTarget")] 
		public gameEntityReference DesiredTarget
		{
			get => GetProperty(ref _desiredTarget);
			set => SetProperty(ref _desiredTarget, value);
		}

		[Ordinal(9)] 
		[RED("desiredCoverId")] 
		public CUInt64 DesiredCoverId
		{
			get => GetProperty(ref _desiredCoverId);
			set => SetProperty(ref _desiredCoverId, value);
		}

		[Ordinal(10)] 
		[RED("currentCoverId")] 
		public CUInt64 CurrentCoverId
		{
			get => GetProperty(ref _currentCoverId);
			set => SetProperty(ref _currentCoverId, value);
		}

		[Ordinal(11)] 
		[RED("currentTarget")] 
		public wCHandle<gameObject> CurrentTarget
		{
			get => GetProperty(ref _currentTarget);
			set => SetProperty(ref _currentTarget, value);
		}

		[Ordinal(12)] 
		[RED("canFireFromCover")] 
		public CBool CanFireFromCover
		{
			get => GetProperty(ref _canFireFromCover);
			set => SetProperty(ref _canFireFromCover, value);
		}

		[Ordinal(13)] 
		[RED("canFireOutOfCover")] 
		public CBool CanFireOutOfCover
		{
			get => GetProperty(ref _canFireOutOfCover);
			set => SetProperty(ref _canFireOutOfCover, value);
		}

		public AIBackgroundCombatDelegate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
