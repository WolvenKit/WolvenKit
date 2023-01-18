using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickHackScreenOpen : redEvent
	{
		[Ordinal(0)] 
		[RED("setToOpen")] 
		public CBool SetToOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickHackScreenOpen()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
