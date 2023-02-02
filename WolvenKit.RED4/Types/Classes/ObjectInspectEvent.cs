using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ObjectInspectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("showItem")] 
		public CBool ShowItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ObjectInspectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
