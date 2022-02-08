using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PachinkoMachine : ArcadeMachine
	{
		[Ordinal(104)] 
		[RED("distractionFXName")] 
		public CName DistractionFXName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PachinkoMachine()
		{
			DistractionFXName = "effect_distraction";
		}
	}
}
