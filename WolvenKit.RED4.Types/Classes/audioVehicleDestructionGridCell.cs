using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleDestructionGridCell : RedBaseClass
	{
		private CName _impactEvent;
		private CName _impactDetailEvent;

		[Ordinal(0)] 
		[RED("impactEvent")] 
		public CName ImpactEvent
		{
			get => GetProperty(ref _impactEvent);
			set => SetProperty(ref _impactEvent, value);
		}

		[Ordinal(1)] 
		[RED("impactDetailEvent")] 
		public CName ImpactDetailEvent
		{
			get => GetProperty(ref _impactDetailEvent);
			set => SetProperty(ref _impactDetailEvent, value);
		}
	}
}
