using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDManagerDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _showHudHintMessege;
		private gamebbScriptID_String _hudHintMessegeContent;

		[Ordinal(0)] 
		[RED("ShowHudHintMessege")] 
		public gamebbScriptID_Bool ShowHudHintMessege
		{
			get
			{
				if (_showHudHintMessege == null)
				{
					_showHudHintMessege = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ShowHudHintMessege", cr2w, this);
				}
				return _showHudHintMessege;
			}
			set
			{
				if (_showHudHintMessege == value)
				{
					return;
				}
				_showHudHintMessege = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("HudHintMessegeContent")] 
		public gamebbScriptID_String HudHintMessegeContent
		{
			get
			{
				if (_hudHintMessegeContent == null)
				{
					_hudHintMessegeContent = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "HudHintMessegeContent", cr2w, this);
				}
				return _hudHintMessegeContent;
			}
			set
			{
				if (_hudHintMessegeContent == value)
				{
					return;
				}
				_hudHintMessegeContent = value;
				PropertySet(this);
			}
		}

		public HUDManagerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
