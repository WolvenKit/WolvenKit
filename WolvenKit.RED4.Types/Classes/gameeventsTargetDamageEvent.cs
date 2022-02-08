using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsTargetDamageEvent : gameeventsTargetHitEvent
	{
		[Ordinal(12)] 
		[RED("damage")] 
		public CFloat Damage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
