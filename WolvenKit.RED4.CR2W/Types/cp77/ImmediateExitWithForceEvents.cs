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
			get
			{
				if (_exitForce == null)
				{
					_exitForce = (gamestateMachineResultVector) CR2WTypeManager.Create("gamestateMachineResultVector", "exitForce", cr2w, this);
				}
				return _exitForce;
			}
			set
			{
				if (_exitForce == value)
				{
					return;
				}
				_exitForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bikeForce")] 
		public gamestateMachineResultVector BikeForce
		{
			get
			{
				if (_bikeForce == null)
				{
					_bikeForce = (gamestateMachineResultVector) CR2WTypeManager.Create("gamestateMachineResultVector", "bikeForce", cr2w, this);
				}
				return _bikeForce;
			}
			set
			{
				if (_bikeForce == value)
				{
					return;
				}
				_bikeForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("knockOverBike")] 
		public CHandle<KnockOverBikeEvent> KnockOverBike
		{
			get
			{
				if (_knockOverBike == null)
				{
					_knockOverBike = (CHandle<KnockOverBikeEvent>) CR2WTypeManager.Create("handle:KnockOverBikeEvent", "knockOverBike", cr2w, this);
				}
				return _knockOverBike;
			}
			set
			{
				if (_knockOverBike == value)
				{
					return;
				}
				_knockOverBike = value;
				PropertySet(this);
			}
		}

		public ImmediateExitWithForceEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
