using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BlacklistPeriodEnded : redEvent
	{
		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public BlacklistPeriodEnded()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
