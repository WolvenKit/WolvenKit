using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareActionAbstractEvents : LeftHandCyberwareEventsTransition
	{
		[Ordinal(0)] 
		[RED("projectileReleased")] 
		public CBool ProjectileReleased
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
