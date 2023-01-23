using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IgnoreListEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bodyID")] 
		public entEntityID BodyID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("removeEvent")] 
		public CBool RemoveEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IgnoreListEvent()
		{
			BodyID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
