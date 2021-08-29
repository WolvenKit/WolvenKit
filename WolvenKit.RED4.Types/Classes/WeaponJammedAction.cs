using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponJammedAction : StatusEffectActions
	{
		private CFloat _jammedWeaponDuration;
		private CFloat _jammedWeaponStartTimeStamp;

		[Ordinal(0)] 
		[RED("jammedWeaponDuration")] 
		public CFloat JammedWeaponDuration
		{
			get => GetProperty(ref _jammedWeaponDuration);
			set => SetProperty(ref _jammedWeaponDuration, value);
		}

		[Ordinal(1)] 
		[RED("jammedWeaponStartTimeStamp")] 
		public CFloat JammedWeaponStartTimeStamp
		{
			get => GetProperty(ref _jammedWeaponStartTimeStamp);
			set => SetProperty(ref _jammedWeaponStartTimeStamp, value);
		}
	}
}
