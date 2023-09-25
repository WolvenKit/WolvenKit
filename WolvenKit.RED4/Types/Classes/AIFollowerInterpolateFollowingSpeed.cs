using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFollowerInterpolateFollowingSpeed : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("enterCondition")] 
		public TweakDBID EnterCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("exitCondition")] 
		public TweakDBID ExitCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("minInterpolationDistanceToDestination")] 
		public CFloat MinInterpolationDistanceToDestination
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxInterpolationDistanceToDestination")] 
		public CFloat MaxInterpolationDistanceToDestination
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxTimeDilation")] 
		public CFloat MaxTimeDilation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("enterConditionInstance")] 
		public CWeakHandle<gamedataAIActionCondition_Record> EnterConditionInstance
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionCondition_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionCondition_Record>>(value);
		}

		[Ordinal(6)] 
		[RED("exitConditionInstace")] 
		public CWeakHandle<gamedataAIActionCondition_Record> ExitConditionInstace
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionCondition_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionCondition_Record>>(value);
		}

		[Ordinal(7)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AIFollowerInterpolateFollowingSpeed()
		{
			Reason = "Following";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
