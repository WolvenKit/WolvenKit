using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_TopbarHubMenuDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isSubmenuHidden;
		private gamebbScriptID_Variant _metaQuestStatus;

		[Ordinal(0)] 
		[RED("IsSubmenuHidden")] 
		public gamebbScriptID_Bool IsSubmenuHidden
		{
			get
			{
				if (_isSubmenuHidden == null)
				{
					_isSubmenuHidden = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsSubmenuHidden", cr2w, this);
				}
				return _isSubmenuHidden;
			}
			set
			{
				if (_isSubmenuHidden == value)
				{
					return;
				}
				_isSubmenuHidden = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("MetaQuestStatus")] 
		public gamebbScriptID_Variant MetaQuestStatus
		{
			get
			{
				if (_metaQuestStatus == null)
				{
					_metaQuestStatus = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "MetaQuestStatus", cr2w, this);
				}
				return _metaQuestStatus;
			}
			set
			{
				if (_metaQuestStatus == value)
				{
					return;
				}
				_metaQuestStatus = value;
				PropertySet(this);
			}
		}

		public UI_TopbarHubMenuDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
