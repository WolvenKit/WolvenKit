using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipSecondaryWeaponCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private wCHandle<AISwitchToSecondaryWeaponCommand> _command;
		private CBool _unEquip;

		[Ordinal(0)] 
		[RED("command")] 
		public wCHandle<AISwitchToSecondaryWeaponCommand> Command
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

		public EquipSecondaryWeaponCommandDelegate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
