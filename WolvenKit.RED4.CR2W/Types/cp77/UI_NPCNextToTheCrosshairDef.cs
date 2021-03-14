using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_NPCNextToTheCrosshairDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _nameplateData;
		private gamebbScriptID_Variant _buffsList;
		private gamebbScriptID_Variant _debuffsList;

		[Ordinal(0)] 
		[RED("NameplateData")] 
		public gamebbScriptID_Variant NameplateData
		{
			get
			{
				if (_nameplateData == null)
				{
					_nameplateData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "NameplateData", cr2w, this);
				}
				return _nameplateData;
			}
			set
			{
				if (_nameplateData == value)
				{
					return;
				}
				_nameplateData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("BuffsList")] 
		public gamebbScriptID_Variant BuffsList
		{
			get
			{
				if (_buffsList == null)
				{
					_buffsList = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "BuffsList", cr2w, this);
				}
				return _buffsList;
			}
			set
			{
				if (_buffsList == value)
				{
					return;
				}
				_buffsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("DebuffsList")] 
		public gamebbScriptID_Variant DebuffsList
		{
			get
			{
				if (_debuffsList == null)
				{
					_debuffsList = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DebuffsList", cr2w, this);
				}
				return _debuffsList;
			}
			set
			{
				if (_debuffsList == value)
				{
					return;
				}
				_debuffsList = value;
				PropertySet(this);
			}
		}

		public UI_NPCNextToTheCrosshairDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
