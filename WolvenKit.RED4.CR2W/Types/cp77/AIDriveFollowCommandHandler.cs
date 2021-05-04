using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveFollowCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outUseKinematic;
		private CHandle<AIArgumentMapping> _outNeedDriver;
		private CHandle<AIArgumentMapping> _outTarget;
		private CHandle<AIArgumentMapping> _outSecureTimeOut;
		private CHandle<AIArgumentMapping> _outDistanceMin;
		private CHandle<AIArgumentMapping> _outDistanceMax;
		private CHandle<AIArgumentMapping> _outStopWhenTargetReached;
		private CHandle<AIArgumentMapping> _outUseTraffic;
		private CHandle<AIArgumentMapping> _outTrafficTryNeighborsForStart;
		private CHandle<AIArgumentMapping> _outTrafficTryNeighborsForEnd;
		private CHandle<AIArgumentMapping> _outAllowStubMovement;

		[Ordinal(1)] 
		[RED("outUseKinematic")] 
		public CHandle<AIArgumentMapping> OutUseKinematic
		{
			get => GetProperty(ref _outUseKinematic);
			set => SetProperty(ref _outUseKinematic, value);
		}

		[Ordinal(2)] 
		[RED("outNeedDriver")] 
		public CHandle<AIArgumentMapping> OutNeedDriver
		{
			get => GetProperty(ref _outNeedDriver);
			set => SetProperty(ref _outNeedDriver, value);
		}

		[Ordinal(3)] 
		[RED("outTarget")] 
		public CHandle<AIArgumentMapping> OutTarget
		{
			get => GetProperty(ref _outTarget);
			set => SetProperty(ref _outTarget, value);
		}

		[Ordinal(4)] 
		[RED("outSecureTimeOut")] 
		public CHandle<AIArgumentMapping> OutSecureTimeOut
		{
			get => GetProperty(ref _outSecureTimeOut);
			set => SetProperty(ref _outSecureTimeOut, value);
		}

		[Ordinal(5)] 
		[RED("outDistanceMin")] 
		public CHandle<AIArgumentMapping> OutDistanceMin
		{
			get => GetProperty(ref _outDistanceMin);
			set => SetProperty(ref _outDistanceMin, value);
		}

		[Ordinal(6)] 
		[RED("outDistanceMax")] 
		public CHandle<AIArgumentMapping> OutDistanceMax
		{
			get => GetProperty(ref _outDistanceMax);
			set => SetProperty(ref _outDistanceMax, value);
		}

		[Ordinal(7)] 
		[RED("outStopWhenTargetReached")] 
		public CHandle<AIArgumentMapping> OutStopWhenTargetReached
		{
			get => GetProperty(ref _outStopWhenTargetReached);
			set => SetProperty(ref _outStopWhenTargetReached, value);
		}

		[Ordinal(8)] 
		[RED("outUseTraffic")] 
		public CHandle<AIArgumentMapping> OutUseTraffic
		{
			get => GetProperty(ref _outUseTraffic);
			set => SetProperty(ref _outUseTraffic, value);
		}

		[Ordinal(9)] 
		[RED("outTrafficTryNeighborsForStart")] 
		public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForStart
		{
			get => GetProperty(ref _outTrafficTryNeighborsForStart);
			set => SetProperty(ref _outTrafficTryNeighborsForStart, value);
		}

		[Ordinal(10)] 
		[RED("outTrafficTryNeighborsForEnd")] 
		public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForEnd
		{
			get => GetProperty(ref _outTrafficTryNeighborsForEnd);
			set => SetProperty(ref _outTrafficTryNeighborsForEnd, value);
		}

		[Ordinal(11)] 
		[RED("outAllowStubMovement")] 
		public CHandle<AIArgumentMapping> OutAllowStubMovement
		{
			get => GetProperty(ref _outAllowStubMovement);
			set => SetProperty(ref _outAllowStubMovement, value);
		}

		public AIDriveFollowCommandHandler(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
