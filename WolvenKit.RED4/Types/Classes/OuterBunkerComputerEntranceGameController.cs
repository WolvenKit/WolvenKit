using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OuterBunkerComputerEntranceGameController : gameuiBaseBunkerComputerGameController
	{
		[Ordinal(2)] 
		[RED("harvestIntroAnimName")] 
		public CName HarvestIntroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("harvestLoop1AnimName")] 
		public CName HarvestLoop1AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("harvestLoop2AnimName")] 
		public CName HarvestLoop2AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("harvestLoop3AnimName")] 
		public CName HarvestLoop3AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("harvestOutroAnimName")] 
		public CName HarvestOutroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public OuterBunkerComputerEntranceGameController()
		{
			HarvestIntroAnimName = "data_harvest_intro";
			HarvestLoop1AnimName = "data_harvest_part_02_loop";
			HarvestLoop2AnimName = "data_harvest_loop";
			HarvestLoop3AnimName = "data_harvest_part_04_loop";
			HarvestOutroAnimName = "data_harvest_outro";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
