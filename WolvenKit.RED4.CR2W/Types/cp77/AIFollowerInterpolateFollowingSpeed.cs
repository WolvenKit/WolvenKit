using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowerInterpolateFollowingSpeed : AIbehaviortaskScript
	{
		private TweakDBID _enterCondition;
		private TweakDBID _exitCondition;
		private CFloat _minInterpolationDistanceToDestination;
		private CFloat _maxInterpolationDistanceToDestination;
		private CFloat _maxTimeDilation;
		private wCHandle<gamedataAIActionCondition_Record> _enterConditionInstance;
		private wCHandle<gamedataAIActionCondition_Record> _exitConditionInstace;
		private CBool _isActive;
		private CName _reason;

		[Ordinal(0)] 
		[RED("enterCondition")] 
		public TweakDBID EnterCondition
		{
			get => GetProperty(ref _enterCondition);
			set => SetProperty(ref _enterCondition, value);
		}

		[Ordinal(1)] 
		[RED("exitCondition")] 
		public TweakDBID ExitCondition
		{
			get => GetProperty(ref _exitCondition);
			set => SetProperty(ref _exitCondition, value);
		}

		[Ordinal(2)] 
		[RED("minInterpolationDistanceToDestination")] 
		public CFloat MinInterpolationDistanceToDestination
		{
			get => GetProperty(ref _minInterpolationDistanceToDestination);
			set => SetProperty(ref _minInterpolationDistanceToDestination, value);
		}

		[Ordinal(3)] 
		[RED("maxInterpolationDistanceToDestination")] 
		public CFloat MaxInterpolationDistanceToDestination
		{
			get => GetProperty(ref _maxInterpolationDistanceToDestination);
			set => SetProperty(ref _maxInterpolationDistanceToDestination, value);
		}

		[Ordinal(4)] 
		[RED("maxTimeDilation")] 
		public CFloat MaxTimeDilation
		{
			get => GetProperty(ref _maxTimeDilation);
			set => SetProperty(ref _maxTimeDilation, value);
		}

		[Ordinal(5)] 
		[RED("enterConditionInstance")] 
		public wCHandle<gamedataAIActionCondition_Record> EnterConditionInstance
		{
			get => GetProperty(ref _enterConditionInstance);
			set => SetProperty(ref _enterConditionInstance, value);
		}

		[Ordinal(6)] 
		[RED("exitConditionInstace")] 
		public wCHandle<gamedataAIActionCondition_Record> ExitConditionInstace
		{
			get => GetProperty(ref _exitConditionInstace);
			set => SetProperty(ref _exitConditionInstace, value);
		}

		[Ordinal(7)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(8)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		public AIFollowerInterpolateFollowingSpeed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
