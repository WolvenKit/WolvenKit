using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ImmediateExitWithForceEvents : ExitingEventsBase
	{
		private gamestateMachineResultVector _exitForce;
		private gamestateMachineResultVector _bikeForce;
		private CHandle<KnockOverBikeEvent> _knockOverBike;

		[Ordinal(3)] 
		[RED("exitForce")] 
		public gamestateMachineResultVector ExitForce
		{
			get => GetProperty(ref _exitForce);
			set => SetProperty(ref _exitForce, value);
		}

		[Ordinal(4)] 
		[RED("bikeForce")] 
		public gamestateMachineResultVector BikeForce
		{
			get => GetProperty(ref _bikeForce);
			set => SetProperty(ref _bikeForce, value);
		}

		[Ordinal(5)] 
		[RED("knockOverBike")] 
		public CHandle<KnockOverBikeEvent> KnockOverBike
		{
			get => GetProperty(ref _knockOverBike);
			set => SetProperty(ref _knockOverBike, value);
		}

		public ImmediateExitWithForceEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
