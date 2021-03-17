using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMenuResource : CResource
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

		public inkMenuResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
