using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class grenadeSpawner : gameweaponObject
	{
		[Ordinal(59)] 
		[RED("isCombatGadgetActive")] 
		public CBool IsCombatGadgetActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
