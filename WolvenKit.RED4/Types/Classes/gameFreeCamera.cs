using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameFreeCamera : gameObject
	{
		[Ordinal(35)] 
		[RED("baseSpeed")] 
		public CFloat BaseSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("analogTurnRate")] 
		public CFloat AnalogTurnRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("mouseTurnRate")] 
		public CFloat MouseTurnRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("activationBlendTime")] 
		public CFloat ActivationBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("deactivationBlendTime")] 
		public CFloat DeactivationBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(40)] 
		[RED("usePhysicalCollision")] 
		public CBool UsePhysicalCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameFreeCamera()
		{
			BaseSpeed = 10.000000F;
			AnalogTurnRate = 100.000000F;
			MouseTurnRate = 7.000000F;
			UsePhysicalCollision = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
