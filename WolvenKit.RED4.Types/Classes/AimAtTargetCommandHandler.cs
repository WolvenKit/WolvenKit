using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AimAtTargetCommandHandler : AIbehaviortaskScript
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
		public CWeakHandle<AIAimAtTargetCommand> CurrentCommand
		{
			get => GetPropertyValue<CWeakHandle<AIAimAtTargetCommand>>();
			set => SetPropertyValue<CWeakHandle<AIAimAtTargetCommand>>(value);
		}

		public AimAtTargetCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
