using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_Cover : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("coverPosition")] 
		public Vector4 CoverPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("coverDirection")] 
		public Vector4 CoverDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("coverState")] 
		public CInt32 CoverState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("coverAngleToAction")] 
		public CFloat CoverAngleToAction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("stance")] 
		public CInt32 Stance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("behavior")] 
		public CInt32 Behavior
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("coverAction")] 
		public CInt32 CoverAction
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("behaviorTime_PreAction")] 
		public CFloat BehaviorTime_PreAction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("behaviorTime_Action")] 
		public CFloat BehaviorTime_Action
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("behaviorTime_PostAction")] 
		public CFloat BehaviorTime_PostAction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimFeature_Cover()
		{
			CoverPosition = new Vector4();
			CoverDirection = new Vector4();
			CoverState = 1;
			BehaviorTime_PreAction = 1.000000F;
			BehaviorTime_Action = 1.000000F;
			BehaviorTime_PostAction = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
