using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetIgnoreAutoDoorCloseEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetIgnoreAutoDoorCloseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
