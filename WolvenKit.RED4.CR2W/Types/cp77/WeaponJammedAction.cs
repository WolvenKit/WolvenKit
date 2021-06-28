using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponJammedAction : StatusEffectActions
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

		public WeaponJammedAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
