using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveFollowEvent : redEvent
	{
		private wCHandle<gameObject> _targetObjToFollow;
		private CFloat _distanceMin;
		private CFloat _distanceMax;
		private CBool _stopWhenTargetReached;
		private CBool _useTraffic;

		[Ordinal(0)] 
		[RED("targetObjToFollow")] 
		public wCHandle<gameObject> TargetObjToFollow
		{
			get => GetProperty(ref _targetObjToFollow);
			set => SetProperty(ref _targetObjToFollow, value);
		}

		[Ordinal(1)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(2)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(3)] 
		[RED("stopWhenTargetReached")] 
		public CBool StopWhenTargetReached
		{
			get => GetProperty(ref _stopWhenTargetReached);
			set => SetProperty(ref _stopWhenTargetReached, value);
		}

		[Ordinal(4)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetProperty(ref _useTraffic);
			set => SetProperty(ref _useTraffic, value);
		}

		public vehicleDriveFollowEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
