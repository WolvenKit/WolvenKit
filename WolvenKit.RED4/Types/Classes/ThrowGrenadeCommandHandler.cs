using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ThrowGrenadeCommandHandler : AIbehaviortaskScript
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
		public CWeakHandle<AIThrowGrenadeCommand> CurrentCommand
		{
			get => GetPropertyValue<CWeakHandle<AIThrowGrenadeCommand>>();
			set => SetPropertyValue<CWeakHandle<AIThrowGrenadeCommand>>(value);
		}

		public ThrowGrenadeCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
