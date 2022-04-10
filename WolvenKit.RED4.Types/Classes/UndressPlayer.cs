using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UndressPlayer : redEvent
	{
		[Ordinal(0)] 
		[RED("isCensored")] 
		public CBool IsCensored
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UndressPlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
