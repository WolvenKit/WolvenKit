using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkMenuResource : CResource
	{
		private CArray<inkMenuEntry> _menusEntries;
		private CArray<CName> _scenariosNames;
		private CName _initialScenarioName;

		[Ordinal(1)] 
		[RED("menusEntries")] 
		public CArray<inkMenuEntry> MenusEntries
		{
			get => GetProperty(ref _menusEntries);
			set => SetProperty(ref _menusEntries, value);
		}

		[Ordinal(2)] 
		[RED("scenariosNames")] 
		public CArray<CName> ScenariosNames
		{
			get => GetProperty(ref _scenariosNames);
			set => SetProperty(ref _scenariosNames, value);
		}

		[Ordinal(3)] 
		[RED("initialScenarioName")] 
		public CName InitialScenarioName
		{
			get => GetProperty(ref _initialScenarioName);
			set => SetProperty(ref _initialScenarioName, value);
		}
	}
}
