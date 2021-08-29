using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entragdollActivationRequestData : RedBaseClass
	{
		private CEnum<entragdollActivationRequestType> _type;
		private CFloat _activationNoGroundThreshold;
		private CBool _activateOnCollision;
		private CBool _applyPowerPose;
		private CBool _applyMomentum;
		private CName _filterDataOverride;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<entragdollActivationRequestType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("activationNoGroundThreshold")] 
		public CFloat ActivationNoGroundThreshold
		{
			get => GetProperty(ref _activationNoGroundThreshold);
			set => SetProperty(ref _activationNoGroundThreshold, value);
		}

		[Ordinal(2)] 
		[RED("activateOnCollision")] 
		public CBool ActivateOnCollision
		{
			get => GetProperty(ref _activateOnCollision);
			set => SetProperty(ref _activateOnCollision, value);
		}

		[Ordinal(3)] 
		[RED("applyPowerPose")] 
		public CBool ApplyPowerPose
		{
			get => GetProperty(ref _applyPowerPose);
			set => SetProperty(ref _applyPowerPose, value);
		}

		[Ordinal(4)] 
		[RED("applyMomentum")] 
		public CBool ApplyMomentum
		{
			get => GetProperty(ref _applyMomentum);
			set => SetProperty(ref _applyMomentum, value);
		}

		[Ordinal(5)] 
		[RED("filterDataOverride")] 
		public CName FilterDataOverride
		{
			get => GetProperty(ref _filterDataOverride);
			set => SetProperty(ref _filterDataOverride, value);
		}
	}
}
