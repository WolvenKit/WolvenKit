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
			get
			{
				if (_menusEntries == null)
				{
					_menusEntries = (CArray<inkMenuEntry>) CR2WTypeManager.Create("array:inkMenuEntry", "menusEntries", cr2w, this);
				}
				return _menusEntries;
			}
			set
			{
				if (_menusEntries == value)
				{
					return;
				}
				_menusEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scenariosNames")] 
		public CArray<CName> ScenariosNames
		{
			get
			{
				if (_scenariosNames == null)
				{
					_scenariosNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "scenariosNames", cr2w, this);
				}
				return _scenariosNames;
			}
			set
			{
				if (_scenariosNames == value)
				{
					return;
				}
				_scenariosNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("initialScenarioName")] 
		public CName InitialScenarioName
		{
			get
			{
				if (_initialScenarioName == null)
				{
					_initialScenarioName = (CName) CR2WTypeManager.Create("CName", "initialScenarioName", cr2w, this);
				}
				return _initialScenarioName;
			}
			set
			{
				if (_initialScenarioName == value)
				{
					return;
				}
				_initialScenarioName = value;
				PropertySet(this);
			}
		}

		public inkMenuResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
