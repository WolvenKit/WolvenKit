using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeChargedHoldEvents : MeleeEventsTransition
	{
		[Ordinal(1)] 
		[RED("clearWeaponCharge")] 
		public CBool ClearWeaponCharge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
