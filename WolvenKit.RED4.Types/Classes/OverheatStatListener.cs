using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OverheatStatListener : gameScriptStatPoolsListener
	{
		private CWeakHandle<gameweaponObject> _weapon;
		private CHandle<UpdateOverheatEvent> _updateEvt;
		private CHandle<StartOverheatEffectEvent> _startEvt;

		[Ordinal(0)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(1)] 
		[RED("updateEvt")] 
		public CHandle<UpdateOverheatEvent> UpdateEvt
		{
			get => GetProperty(ref _updateEvt);
			set => SetProperty(ref _updateEvt, value);
		}

		[Ordinal(2)] 
		[RED("startEvt")] 
		public CHandle<StartOverheatEffectEvent> StartEvt
		{
			get => GetProperty(ref _startEvt);
			set => SetProperty(ref _startEvt, value);
		}
	}
}
