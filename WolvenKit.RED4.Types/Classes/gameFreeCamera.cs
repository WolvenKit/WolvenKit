using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFreeCamera : gameObject
	{
		[Ordinal(40)] 
		[RED("baseSpeed")] 
		public CFloat BaseSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("analogTurnRate")] 
		public CFloat AnalogTurnRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("mouseTurnRate")] 
		public CFloat MouseTurnRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("activationBlendTime")] 
		public CFloat ActivationBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("deactivationBlendTime")] 
		public CFloat DeactivationBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
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
		}
	}
}
