using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_LevelUpDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _level;

		[Ordinal(0)] 
		[RED("level")] 
		public gamebbScriptID_Variant Level
		{
			get
			{
				if (_level == null)
				{
					_level = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		public UI_LevelUpDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
