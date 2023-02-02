using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TagObjectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TagObjectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
