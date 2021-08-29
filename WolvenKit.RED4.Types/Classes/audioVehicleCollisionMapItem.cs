using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleCollisionMapItem : RedBaseClass
	{
		private CName _name;
		private CName _impactEvent;
		private CName _scrapingLoopStart;
		private CName _scrapingLoopEnd;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("impactEvent")] 
		public CName ImpactEvent
		{
			get => GetProperty(ref _impactEvent);
			set => SetProperty(ref _impactEvent, value);
		}

		[Ordinal(2)] 
		[RED("scrapingLoopStart")] 
		public CName ScrapingLoopStart
		{
			get => GetProperty(ref _scrapingLoopStart);
			set => SetProperty(ref _scrapingLoopStart, value);
		}

		[Ordinal(3)] 
		[RED("scrapingLoopEnd")] 
		public CName ScrapingLoopEnd
		{
			get => GetProperty(ref _scrapingLoopEnd);
			set => SetProperty(ref _scrapingLoopEnd, value);
		}
	}
}
