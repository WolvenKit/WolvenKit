using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CW_MuteArmDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _muteArmActive;
		private gamebbScriptID_Float _muteArmRadius;

		[Ordinal(0)] 
		[RED("MuteArmActive")] 
		public gamebbScriptID_Bool MuteArmActive
		{
			get
			{
				if (_muteArmActive == null)
				{
					_muteArmActive = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "MuteArmActive", cr2w, this);
				}
				return _muteArmActive;
			}
			set
			{
				if (_muteArmActive == value)
				{
					return;
				}
				_muteArmActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("MuteArmRadius")] 
		public gamebbScriptID_Float MuteArmRadius
		{
			get
			{
				if (_muteArmRadius == null)
				{
					_muteArmRadius = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "MuteArmRadius", cr2w, this);
				}
				return _muteArmRadius;
			}
			set
			{
				if (_muteArmRadius == value)
				{
					return;
				}
				_muteArmRadius = value;
				PropertySet(this);
			}
		}

		public CW_MuteArmDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
