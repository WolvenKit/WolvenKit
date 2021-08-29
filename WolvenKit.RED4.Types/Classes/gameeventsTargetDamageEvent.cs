using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsTargetDamageEvent : gameeventsTargetHitEvent
	{
		private CFloat _damage;

		[Ordinal(12)] 
		[RED("damage")] 
		public CFloat Damage
		{
			get => GetProperty(ref _damage);
			set => SetProperty(ref _damage, value);
		}
	}
}
