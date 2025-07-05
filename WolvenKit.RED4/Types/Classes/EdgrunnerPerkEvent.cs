using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EdgrunnerPerkEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isPurchased")] 
		public CBool IsPurchased
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EdgrunnerPerkEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
