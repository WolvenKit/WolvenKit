using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuEventBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_CName _menuEventToTrigger;

		[Ordinal(0)] 
		[RED("MenuEventToTrigger")] 
		public gamebbScriptID_CName MenuEventToTrigger
		{
			get
			{
				if (_menuEventToTrigger == null)
				{
					_menuEventToTrigger = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "MenuEventToTrigger", cr2w, this);
				}
				return _menuEventToTrigger;
			}
			set
			{
				if (_menuEventToTrigger == value)
				{
					return;
				}
				_menuEventToTrigger = value;
				PropertySet(this);
			}
		}

		public MenuEventBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
