using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkAnimAdjuster : animAnimNode_SkAnim
	{
		[Ordinal(18)] 
		[RED("targetPositionWs")] 
		public animVectorLink TargetPositionWs
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(19)] 
		[RED("targetDirectionWs")] 
		public animVectorLink TargetDirectionWs
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(20)] 
		[RED("initialForwardVector")] 
		public Vector4 InitialForwardVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(21)] 
		[RED("startAdjustmentEventName")] 
		public CName StartAdjustmentEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("endAdjustmentEventName")] 
		public CName EndAdjustmentEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_SkAnimAdjuster()
		{
			TargetPositionWs = new animVectorLink();
			TargetDirectionWs = new animVectorLink();
			InitialForwardVector = new Vector4 { Y = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
