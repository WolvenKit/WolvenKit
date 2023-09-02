using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AISearchingLookat : AIGenericStaticLookatTask
	{
		[Ordinal(4)] 
		[RED("minAngleDifferenceMapping")] 
		public CHandle<AIArgumentMapping> MinAngleDifferenceMapping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("minAngleDifference")] 
		public CFloat MinAngleDifference
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("maxLookAroundAngleMapping")] 
		public CHandle<AIArgumentMapping> MaxLookAroundAngleMapping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("maxLookAroundAngle")] 
		public CFloat MaxLookAroundAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("currentTarget")] 
		public Vector4 CurrentTarget
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(9)] 
		[RED("lastTarget")] 
		public Vector4 LastTarget
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(10)] 
		[RED("targetSwitchTimeStamp")] 
		public CFloat TargetSwitchTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("targetSwitchCooldown")] 
		public CFloat TargetSwitchCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("sideHorizontal")] 
		public CInt32 SideHorizontal
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("sideVertical")] 
		public CInt32 SideVertical
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AISearchingLookat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
