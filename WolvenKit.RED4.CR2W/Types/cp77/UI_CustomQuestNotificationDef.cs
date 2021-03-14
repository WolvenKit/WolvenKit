using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CustomQuestNotificationDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _data;

		[Ordinal(0)] 
		[RED("data")] 
		public gamebbScriptID_Variant Data
		{
			get
			{
				if (_data == null)
				{
					_data = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public UI_CustomQuestNotificationDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
