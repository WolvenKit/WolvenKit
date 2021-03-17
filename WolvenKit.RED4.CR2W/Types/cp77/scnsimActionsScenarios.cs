using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnsimActionsScenarios : CVariable
	{
		private CArray<scnsimActionsScenariosNodeScenarios> _allScenarios;

		[Ordinal(0)] 
		[RED("allScenarios")] 
		public CArray<scnsimActionsScenariosNodeScenarios> AllScenarios
		{
			get => GetProperty(ref _allScenarios);
			set => SetProperty(ref _allScenarios, value);
		}

		public scnsimActionsScenarios(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
