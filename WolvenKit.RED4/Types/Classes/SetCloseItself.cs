using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetCloseItself : redEvent
	{
		[Ordinal(0)] 
		[RED("automaticallyClosesItself")] 
		public CBool AutomaticallyClosesItself
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetCloseItself()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
