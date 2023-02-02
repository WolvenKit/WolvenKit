using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPlayerListGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("playerEntries")] 
		public CArray<PlayerListEntryData> PlayerEntries
		{
			get => GetPropertyValue<CArray<PlayerListEntryData>>();
			set => SetPropertyValue<CArray<PlayerListEntryData>>(value);
		}

		[Ordinal(10)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public gameuiPlayerListGameController()
		{
			PlayerEntries = new();
			Container = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
