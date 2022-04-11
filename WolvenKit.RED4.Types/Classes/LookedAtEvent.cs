using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LookedAtEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
