using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entragdollActivationRequestData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<entragdollActivationRequestType> Type
		{
			get => GetPropertyValue<CEnum<entragdollActivationRequestType>>();
			set => SetPropertyValue<CEnum<entragdollActivationRequestType>>(value);
		}

		[Ordinal(1)] 
		[RED("activationNoGroundThreshold")] 
		public CFloat ActivationNoGroundThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("activateOnCollision")] 
		public CBool ActivateOnCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("applyPowerPose")] 
		public CBool ApplyPowerPose
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("applyMomentum")] 
		public CBool ApplyMomentum
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("filterDataOverride")] 
		public CName FilterDataOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("calculateEarlyPositionGroundHeight")] 
		public CBool CalculateEarlyPositionGroundHeight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entragdollActivationRequestData()
		{
			ActivateOnCollision = true;
			ApplyPowerPose = true;
			ApplyMomentum = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
