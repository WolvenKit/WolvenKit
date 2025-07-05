using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PendingSecuritySystemDisable : redEvent
	{
		[Ordinal(0)] 
		[RED("isPending")] 
		public CBool IsPending
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PendingSecuritySystemDisable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
