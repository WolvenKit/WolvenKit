using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InjectLookatTargetCommandTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("currentCommand")] 
		public CWeakHandle<AIInjectLookatTargetCommand> CurrentCommand
		{
			get => GetPropertyValue<CWeakHandle<AIInjectLookatTargetCommand>>();
			set => SetPropertyValue<CWeakHandle<AIInjectLookatTargetCommand>>(value);
		}

		[Ordinal(2)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("commandDuration")] 
		public CFloat CommandDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public InjectLookatTargetCommandTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
