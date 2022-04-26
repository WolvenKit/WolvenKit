using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MenuItemDimRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("dim")] 
		public CBool Dim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MenuItemDimRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
