using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFreeCamera : gameObject
	{
		private CFloat _baseSpeed;
		private CFloat _analogTurnRate;
		private CFloat _mouseTurnRate;
		private CFloat _activationBlendTime;
		private CFloat _deactivationBlendTime;
		private CBool _usePhysicalCollision;

		[Ordinal(40)] 
		[RED("baseSpeed")] 
		public CFloat BaseSpeed
		{
			get => GetProperty(ref _baseSpeed);
			set => SetProperty(ref _baseSpeed, value);
		}

		[Ordinal(41)] 
		[RED("analogTurnRate")] 
		public CFloat AnalogTurnRate
		{
			get => GetProperty(ref _analogTurnRate);
			set => SetProperty(ref _analogTurnRate, value);
		}

		[Ordinal(42)] 
		[RED("mouseTurnRate")] 
		public CFloat MouseTurnRate
		{
			get => GetProperty(ref _mouseTurnRate);
			set => SetProperty(ref _mouseTurnRate, value);
		}

		[Ordinal(43)] 
		[RED("activationBlendTime")] 
		public CFloat ActivationBlendTime
		{
			get => GetProperty(ref _activationBlendTime);
			set => SetProperty(ref _activationBlendTime, value);
		}

		[Ordinal(44)] 
		[RED("deactivationBlendTime")] 
		public CFloat DeactivationBlendTime
		{
			get => GetProperty(ref _deactivationBlendTime);
			set => SetProperty(ref _deactivationBlendTime, value);
		}

		[Ordinal(45)] 
		[RED("usePhysicalCollision")] 
		public CBool UsePhysicalCollision
		{
			get => GetProperty(ref _usePhysicalCollision);
			set => SetProperty(ref _usePhysicalCollision, value);
		}
	}
}
