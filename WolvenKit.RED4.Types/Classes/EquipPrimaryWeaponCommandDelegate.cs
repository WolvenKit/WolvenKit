using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipPrimaryWeaponCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] 
		[RED("command")] 
		public CWeakHandle<AISwitchToPrimaryWeaponCommand> Command
		{
			get => GetPropertyValue<CWeakHandle<AISwitchToPrimaryWeaponCommand>>();
			set => SetPropertyValue<CWeakHandle<AISwitchToPrimaryWeaponCommand>>(value);
		}

		[Ordinal(1)] 
		[RED("unEquip")] 
		public CBool UnEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
