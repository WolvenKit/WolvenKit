using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipSecondaryWeaponCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] 
		[RED("command")] 
		public CWeakHandle<AISwitchToSecondaryWeaponCommand> Command
		{
			get => GetPropertyValue<CWeakHandle<AISwitchToSecondaryWeaponCommand>>();
			set => SetPropertyValue<CWeakHandle<AISwitchToSecondaryWeaponCommand>>(value);
		}

		[Ordinal(1)] 
		[RED("unEquip")] 
		public CBool UnEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EquipSecondaryWeaponCommandDelegate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
