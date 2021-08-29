using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipSecondaryWeaponCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CWeakHandle<AISwitchToSecondaryWeaponCommand> _command;
		private CBool _unEquip;

		[Ordinal(0)] 
		[RED("command")] 
		public CWeakHandle<AISwitchToSecondaryWeaponCommand> Command
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
	}
}
