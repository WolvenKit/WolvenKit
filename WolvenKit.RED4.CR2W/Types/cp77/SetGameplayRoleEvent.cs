using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetGameplayRoleEvent : redEvent
	{
		private CEnum<EGameplayRole> _gameplayRole;

		[Ordinal(0)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get
			{
				if (_gameplayRole == null)
				{
					_gameplayRole = (CEnum<EGameplayRole>) CR2WTypeManager.Create("EGameplayRole", "gameplayRole", cr2w, this);
				}
				return _gameplayRole;
			}
			set
			{
				if (_gameplayRole == value)
				{
					return;
				}
				_gameplayRole = value;
				PropertySet(this);
			}
		}

		public SetGameplayRoleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
