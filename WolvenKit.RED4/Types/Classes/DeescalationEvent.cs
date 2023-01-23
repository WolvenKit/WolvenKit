using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeescalationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("originalNotification")] 
		public CHandle<SecuritySystemInput> OriginalNotification
		{
			get => GetPropertyValue<CHandle<SecuritySystemInput>>();
			set => SetPropertyValue<CHandle<SecuritySystemInput>>(value);
		}

		public DeescalationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
