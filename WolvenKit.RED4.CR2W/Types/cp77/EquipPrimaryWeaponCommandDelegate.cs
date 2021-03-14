using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipPrimaryWeaponCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private wCHandle<AISwitchToPrimaryWeaponCommand> _command;
		private CBool _unEquip;

		[Ordinal(0)] 
		[RED("command")] 
		public wCHandle<AISwitchToPrimaryWeaponCommand> Command
		{
			get
			{
				if (_command == null)
				{
					_command = (wCHandle<AISwitchToPrimaryWeaponCommand>) CR2WTypeManager.Create("whandle:AISwitchToPrimaryWeaponCommand", "command", cr2w, this);
				}
				return _command;
			}
			set
			{
				if (_command == value)
				{
					return;
				}
				_command = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("unEquip")] 
		public CBool UnEquip
		{
			get
			{
				if (_unEquip == null)
				{
					_unEquip = (CBool) CR2WTypeManager.Create("Bool", "unEquip", cr2w, this);
				}
				return _unEquip;
			}
			set
			{
				if (_unEquip == value)
				{
					return;
				}
				_unEquip = value;
				PropertySet(this);
			}
		}

		public EquipPrimaryWeaponCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
