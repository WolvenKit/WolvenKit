using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UseCoverCommandHandler : AIbehaviortaskScript
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
		public CWeakHandle<AIUseCoverCommand> CurrentCommand
		{
			get => GetPropertyValue<CWeakHandle<AIUseCoverCommand>>();
			set => SetPropertyValue<CWeakHandle<AIUseCoverCommand>>(value);
		}

		public UseCoverCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
