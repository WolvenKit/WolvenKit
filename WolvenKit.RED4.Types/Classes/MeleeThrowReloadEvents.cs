using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeThrowReloadEvents : MeleeEventsTransition
	{
		[Ordinal(1)] 
		[RED("isPlayerAiming")] 
		public CBool IsPlayerAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
