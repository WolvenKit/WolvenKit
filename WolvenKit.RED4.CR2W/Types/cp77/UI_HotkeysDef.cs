using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HotkeysDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _modifiedHotkey;

		[Ordinal(0)] 
		[RED("ModifiedHotkey")] 
		public gamebbScriptID_Variant ModifiedHotkey
		{
			get
			{
				if (_modifiedHotkey == null)
				{
					_modifiedHotkey = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ModifiedHotkey", cr2w, this);
				}
				return _modifiedHotkey;
			}
			set
			{
				if (_modifiedHotkey == value)
				{
					return;
				}
				_modifiedHotkey = value;
				PropertySet(this);
			}
		}

		public UI_HotkeysDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
