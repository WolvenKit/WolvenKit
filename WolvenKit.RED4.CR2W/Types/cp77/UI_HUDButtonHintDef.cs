using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HUDButtonHintDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _actionsData;

		[Ordinal(0)] 
		[RED("ActionsData")] 
		public gamebbScriptID_Variant ActionsData
		{
			get
			{
				if (_actionsData == null)
				{
					_actionsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ActionsData", cr2w, this);
				}
				return _actionsData;
			}
			set
			{
				if (_actionsData == value)
				{
					return;
				}
				_actionsData = value;
				PropertySet(this);
			}
		}

		public UI_HUDButtonHintDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
