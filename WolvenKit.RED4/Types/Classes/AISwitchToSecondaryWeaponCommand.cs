using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AISwitchToSecondaryWeaponCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("unEquip")] 
		public CBool UnEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AISwitchToSecondaryWeaponCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
