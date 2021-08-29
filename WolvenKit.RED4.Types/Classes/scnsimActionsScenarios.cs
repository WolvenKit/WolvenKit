using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnsimActionsScenarios : RedBaseClass
	{
		private CArray<scnsimActionsScenariosNodeScenarios> _allScenarios;

		[Ordinal(0)] 
		[RED("allScenarios")] 
		public CArray<scnsimActionsScenariosNodeScenarios> AllScenarios
		{
			get => GetProperty(ref _allScenarios);
			set => SetProperty(ref _allScenarios, value);
		}
	}
}
