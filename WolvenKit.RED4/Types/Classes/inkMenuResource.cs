using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkMenuResource : CResource
	{
		[Ordinal(1)] 
		[RED("menusEntries")] 
		public CArray<inkMenuEntry> MenusEntries
		{
			get => GetPropertyValue<CArray<inkMenuEntry>>();
			set => SetPropertyValue<CArray<inkMenuEntry>>(value);
		}

		[Ordinal(2)] 
		[RED("scenariosNames")] 
		public CArray<CName> ScenariosNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("initialScenarioName")] 
		public CName InitialScenarioName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkMenuResource()
		{
			MenusEntries = new();
			ScenariosNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
