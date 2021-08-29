using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class grenadeSpawner : gameweaponObject
	{
		private CBool _isCombatGadgetActive;

		[Ordinal(62)] 
		[RED("isCombatGadgetActive")] 
		public CBool IsCombatGadgetActive
		{
			get => GetProperty(ref _isCombatGadgetActive);
			set => SetProperty(ref _isCombatGadgetActive, value);
		}
	}
}
