using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystemSupport : redEvent
	{
		[Ordinal(0)] 
		[RED("supportGranted")] 
		public CBool SupportGranted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecuritySystemSupport()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
