using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveFromBlacklistEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("entityIDToRemove")] 
		public entEntityID EntityIDToRemove
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public RemoveFromBlacklistEvent()
		{
			EntityIDToRemove = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
