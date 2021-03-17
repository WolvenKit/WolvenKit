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
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}

		[Ordinal(1)] 
		[RED("unEquip")] 
		public CBool UnEquip
		{
			get => GetProperty(ref _unEquip);
			set => SetProperty(ref _unEquip, value);
		}

		public EquipPrimaryWeaponCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
