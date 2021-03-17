using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveFollowTargetTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _useKinematic;
		private CHandle<AIArgumentMapping> _needDriver;
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _secureTimeOut;
		private CHandle<AIArgumentMapping> _distanceMin;
		private CHandle<AIArgumentMapping> _distanceMax;
		private CHandle<AIArgumentMapping> _isPlayer;
		private CHandle<AIArgumentMapping> _stopHasReachedTarget;
		private CHandle<AIArgumentMapping> _useTraffic;
		private CHandle<AIArgumentMapping> _allowStubMovement;

		[Ordinal(1)] 
		[RED("useKinematic")] 
		public CHandle<AIArgumentMapping> UseKinematic
		{
			get => GetProperty(ref _useKinematic);
			set => SetProperty(ref _useKinematic, value);
		}

		[Ordinal(2)] 
		[RED("needDriver")] 
		public CHandle<AIArgumentMapping> NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		[Ordinal(3)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(4)] 
		[RED("secureTimeOut")] 
		public CHandle<AIArgumentMapping> SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}

		[Ordinal(5)] 
		[RED("distanceMin")] 
		public CHandle<AIArgumentMapping> DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(6)] 
		[RED("distanceMax")] 
		public CHandle<AIArgumentMapping> DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(7)] 
		[RED("isPlayer")] 
		public CHandle<AIArgumentMapping> IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(8)] 
		[RED("stopHasReachedTarget")] 
		public CHandle<AIArgumentMapping> StopHasReachedTarget
		{
			get => GetProperty(ref _stopHasReachedTarget);
			set => SetProperty(ref _stopHasReachedTarget, value);
		}

		[Ordinal(9)] 
		[RED("useTraffic")] 
		public CHandle<AIArgumentMapping> UseTraffic
		{
			get => GetProperty(ref _useTraffic);
			set => SetProperty(ref _useTraffic, value);
		}

		[Ordinal(10)] 
		[RED("allowStubMovement")] 
		public CHandle<AIArgumentMapping> AllowStubMovement
		{
			get => GetProperty(ref _allowStubMovement);
			set => SetProperty(ref _allowStubMovement, value);
		}

		public AIbehaviorDriveFollowTargetTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
