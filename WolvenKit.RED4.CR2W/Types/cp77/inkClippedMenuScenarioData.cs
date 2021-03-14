using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkClippedMenuScenarioData : IScriptable
	{
		private CArray<CName> _menus;

		[Ordinal(0)] 
		[RED("menus")] 
		public CArray<CName> Menus
		{
			get
			{
				if (_menus == null)
				{
					_menus = (CArray<CName>) CR2WTypeManager.Create("array:CName", "menus", cr2w, this);
				}
				return _menus;
			}
			set
			{
				if (_menus == value)
				{
					return;
				}
				_menus = value;
				PropertySet(this);
			}
		}

		public inkClippedMenuScenarioData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
