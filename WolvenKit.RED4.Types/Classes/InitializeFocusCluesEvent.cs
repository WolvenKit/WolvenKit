using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InitializeFocusCluesEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public InitializeFocusCluesEvent()
		{
			RequesterID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
