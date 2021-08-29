using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNpcPuppetReplicatedState : gamePuppetReplicatedState
	{
		private gameWeaponsReplicatedState _weaponStates;

		[Ordinal(12)] 
		[RED("weaponStates")] 
		public gameWeaponsReplicatedState WeaponStates
		{
			get => GetProperty(ref _weaponStates);
			set => SetProperty(ref _weaponStates, value);
		}
	}
}
