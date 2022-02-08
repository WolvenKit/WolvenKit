using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingsMenuUserData : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("isDlcSettings")] 
		public CBool IsDlcSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
