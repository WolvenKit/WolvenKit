using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDestructionGridCell : CVariable
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

		public audioVehicleDestructionGridCell(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
