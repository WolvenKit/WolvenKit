using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isActive;
		private gamebbScriptID_Uint32 _playerHealthState;

		[Ordinal(0)] 
		[RED("IsActive")] 
		public gamebbScriptID_Bool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("PlayerHealthState")] 
		public gamebbScriptID_Uint32 PlayerHealthState
		{
			get
			{
				if (_playerHealthState == null)
				{
					_playerHealthState = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "PlayerHealthState", cr2w, this);
				}
				return _playerHealthState;
			}
			set
			{
				if (_playerHealthState == value)
				{
					return;
				}
				_playerHealthState = value;
				PropertySet(this);
			}
		}

		public PhotoModeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
