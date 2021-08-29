using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DamageStatListener : gameScriptStatsListener
	{
		private CWeakHandle<gameweaponObject> _weapon;
		private CHandle<UpdateDamageChangeEvent> _updateEvt;

		[Ordinal(0)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(1)] 
		[RED("updateEvt")] 
		public CHandle<UpdateDamageChangeEvent> UpdateEvt
		{
			get => GetProperty(ref _updateEvt);
			set => SetProperty(ref _updateEvt, value);
		}
	}
}
