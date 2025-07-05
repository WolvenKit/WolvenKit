using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIBackgroundCombatDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AIBackgroundCombatCommand> Command
		{
			get => GetPropertyValue<CHandle<AIBackgroundCombatCommand>>();
			set => SetPropertyValue<CHandle<AIBackgroundCombatCommand>>(value);
		}

		[Ordinal(1)] 
		[RED("execute")] 
		public CBool Execute
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("steps")] 
		public CArray<AIBackgroundCombatStep> Steps
		{
			get => GetPropertyValue<CArray<AIBackgroundCombatStep>>();
			set => SetPropertyValue<CArray<AIBackgroundCombatStep>>(value);
		}

		[Ordinal(3)] 
		[RED("currentStep")] 
		public CInt32 CurrentStep
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("desiredCover")] 
		public NodeRef DesiredCover
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(5)] 
		[RED("desiredCoverExposureMethod")] 
		public CEnum<AICoverExposureMethod> DesiredCoverExposureMethod
		{
			get => GetPropertyValue<CEnum<AICoverExposureMethod>>();
			set => SetPropertyValue<CEnum<AICoverExposureMethod>>(value);
		}

		[Ordinal(6)] 
		[RED("desiredDestination")] 
		public NodeRef DesiredDestination
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(7)] 
		[RED("hasDesiredTarget")] 
		public CBool HasDesiredTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("desiredTarget")] 
		public gameEntityReference DesiredTarget
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(9)] 
		[RED("desiredCoverId")] 
		public CUInt64 DesiredCoverId
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(10)] 
		[RED("currentCoverId")] 
		public CUInt64 CurrentCoverId
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(11)] 
		[RED("currentTarget")] 
		public CWeakHandle<gameObject> CurrentTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(12)] 
		[RED("canFireFromCover")] 
		public CBool CanFireFromCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("canFireOutOfCover")] 
		public CBool CanFireOutOfCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIBackgroundCombatDelegate()
		{
			Steps = new();
			DesiredTarget = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
