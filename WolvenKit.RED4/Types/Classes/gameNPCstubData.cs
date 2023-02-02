using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNPCstubData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spawnerID")] 
		public entEntityID SpawnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public CName EntryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameNPCstubData()
		{
			SpawnerID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
