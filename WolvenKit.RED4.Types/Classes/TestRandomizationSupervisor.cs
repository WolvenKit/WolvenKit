using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TestRandomizationSupervisor : genScriptedRandomizationSupervisor
	{
		[Ordinal(0)] 
		[RED("firstWasGenerated")] 
		public CBool FirstWasGenerated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TestRandomizationSupervisor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
