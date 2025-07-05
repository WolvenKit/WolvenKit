using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShootCommandHandler : AIbehaviortaskScript
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
		public CWeakHandle<AIShootCommand> CurrentCommand
		{
			get => GetPropertyValue<CWeakHandle<AIShootCommand>>();
			set => SetPropertyValue<CWeakHandle<AIShootCommand>>(value);
		}

		public ShootCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
