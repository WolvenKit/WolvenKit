using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ChatBoxDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _textList;

		[Ordinal(0)] 
		[RED("TextList")] 
		public gamebbScriptID_Variant TextList
		{
			get
			{
				if (_textList == null)
				{
					_textList = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "TextList", cr2w, this);
				}
				return _textList;
			}
			set
			{
				if (_textList == value)
				{
					return;
				}
				_textList = value;
				PropertySet(this);
			}
		}

		public UI_ChatBoxDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
