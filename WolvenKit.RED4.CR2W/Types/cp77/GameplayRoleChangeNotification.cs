using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayRoleChangeNotification : redEvent
	{
		private CEnum<EGameplayRole> _newRole;
		private CEnum<EGameplayRole> _oldRole;

		[Ordinal(0)] 
		[RED("newRole")] 
		public CEnum<EGameplayRole> NewRole
		{
			get
			{
				if (_newRole == null)
				{
					_newRole = (CEnum<EGameplayRole>) CR2WTypeManager.Create("EGameplayRole", "newRole", cr2w, this);
				}
				return _newRole;
			}
			set
			{
				if (_newRole == value)
				{
					return;
				}
				_newRole = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("oldRole")] 
		public CEnum<EGameplayRole> OldRole
		{
			get
			{
				if (_oldRole == null)
				{
					_oldRole = (CEnum<EGameplayRole>) CR2WTypeManager.Create("EGameplayRole", "oldRole", cr2w, this);
				}
				return _oldRole;
			}
			set
			{
				if (_oldRole == value)
				{
					return;
				}
				_oldRole = value;
				PropertySet(this);
			}
		}

		public GameplayRoleChangeNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
