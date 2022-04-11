using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponRegisterChargeStatListener : redEvent
	{
		[Ordinal(0)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
