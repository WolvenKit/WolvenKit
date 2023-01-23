using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsFacingTowardsSource : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)] 
		[RED("applyForPlayer")] 
		public CBool ApplyForPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("applyForNPCs")] 
		public CBool ApplyForNPCs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("maxAllowedAngleYaw")] 
		public CFloat MaxAllowedAngleYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxAllowedAnglePitch")] 
		public CFloat MaxAllowedAnglePitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public IsFacingTowardsSource()
		{
			MaxAllowedAngleYaw = 90.000000F;
			MaxAllowedAnglePitch = 45.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
