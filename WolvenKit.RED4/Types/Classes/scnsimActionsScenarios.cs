using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnsimActionsScenarios : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("allScenarios")] 
		public CArray<scnsimActionsScenariosNodeScenarios> AllScenarios
		{
			get => GetPropertyValue<CArray<scnsimActionsScenariosNodeScenarios>>();
			set => SetPropertyValue<CArray<scnsimActionsScenariosNodeScenarios>>(value);
		}

		public scnsimActionsScenarios()
		{
			AllScenarios = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
