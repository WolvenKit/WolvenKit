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
			get
			{
				if (_allScenarios == null)
				{
					_allScenarios = (CArray<scnsimActionsScenariosNodeScenarios>) CR2WTypeManager.Create("array:scnsimActionsScenariosNodeScenarios", "allScenarios", cr2w, this);
				}
				return _allScenarios;
			}
			set
			{
				if (_allScenarios == value)
				{
					return;
				}
				_allScenarios = value;
				PropertySet(this);
			}
		}

		public scnsimActionsScenarios(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
