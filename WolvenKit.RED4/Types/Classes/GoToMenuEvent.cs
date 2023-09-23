using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GoToMenuEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("menuType")] 
		public CEnum<EComputerMenuType> MenuType
		{
			get => GetPropertyValue<CEnum<EComputerMenuType>>();
			set => SetPropertyValue<CEnum<EComputerMenuType>>(value);
		}

		[Ordinal(1)] 
		[RED("wakeUp")] 
		public CBool WakeUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public GoToMenuEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
