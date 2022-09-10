using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PachinkoMachine : ArcadeMachine
	{
		[Ordinal(102)] 
		[RED("distractionFXName")] 
		public CName DistractionFXName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PachinkoMachine()
		{
			DistractionFXName = "effect_distraction";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
