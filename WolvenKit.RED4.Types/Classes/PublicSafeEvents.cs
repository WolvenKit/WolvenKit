using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PublicSafeEvents : WeaponEventsTransition
	{
		[Ordinal(3)] 
		[RED("weaponUnequipRequestSent")] 
		public CBool WeaponUnequipRequestSent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
