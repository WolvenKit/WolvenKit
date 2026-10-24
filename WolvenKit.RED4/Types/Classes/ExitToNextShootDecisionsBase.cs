using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class ExitToNextShootDecisionsBase : ShootTransition
	{
		[Ordinal(0)] 
		[RED("enteredStateVarName")] 
		public CName EnteredStateVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ExitToNextShootDecisionsBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
