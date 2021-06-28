using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetFollowTarget : FollowVehicleTask
	{
		private CHandle<gameIBlackboard> _blackboard;
		private wCHandle<vehicleBaseObject> _vehicle;
		private CFloat _lastTime;
		private CFloat _timeout;
		private CFloat _timeoutDuration;

		[Ordinal(0)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(1)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(2)] 
		[RED("lastTime")] 
		public CFloat LastTime
		{
			get => GetProperty(ref _lastTime);
			set => SetProperty(ref _lastTime, value);
		}

		[Ordinal(3)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetProperty(ref _timeout);
			set => SetProperty(ref _timeout, value);
		}

		[Ordinal(4)] 
		[RED("timeoutDuration")] 
		public CFloat TimeoutDuration
		{
			get => GetProperty(ref _timeoutDuration);
			set => SetProperty(ref _timeoutDuration, value);
		}

		public GetFollowTarget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
