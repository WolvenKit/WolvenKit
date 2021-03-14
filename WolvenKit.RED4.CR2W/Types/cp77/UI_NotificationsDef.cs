using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_NotificationsDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _warningMessage;
		private gamebbScriptID_Variant _onscreenMessage;

		[Ordinal(0)] 
		[RED("WarningMessage")] 
		public gamebbScriptID_Variant WarningMessage
		{
			get
			{
				if (_warningMessage == null)
				{
					_warningMessage = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "WarningMessage", cr2w, this);
				}
				return _warningMessage;
			}
			set
			{
				if (_warningMessage == value)
				{
					return;
				}
				_warningMessage = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("OnscreenMessage")] 
		public gamebbScriptID_Variant OnscreenMessage
		{
			get
			{
				if (_onscreenMessage == null)
				{
					_onscreenMessage = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "OnscreenMessage", cr2w, this);
				}
				return _onscreenMessage;
			}
			set
			{
				if (_onscreenMessage == value)
				{
					return;
				}
				_onscreenMessage = value;
				PropertySet(this);
			}
		}

		public UI_NotificationsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
