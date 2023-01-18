using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameReplicatedAnimEvent : entReplicatedItem
	{
		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameReplicatedAnimEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
