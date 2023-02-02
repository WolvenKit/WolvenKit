using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SendEquipWeaponCommand : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("secondary")] 
		public CBool Secondary
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SendEquipWeaponCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
