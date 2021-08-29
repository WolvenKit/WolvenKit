using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForkliftSetup : RedBaseClass
	{
		private CName _actionActivateName;
		private CFloat _liftingAnimationTime;
		private CBool _hasDistractionQuickhack;

		[Ordinal(0)] 
		[RED("actionActivateName")] 
		public CName ActionActivateName
		{
			get => GetProperty(ref _actionActivateName);
			set => SetProperty(ref _actionActivateName, value);
		}

		[Ordinal(1)] 
		[RED("liftingAnimationTime")] 
		public CFloat LiftingAnimationTime
		{
			get => GetProperty(ref _liftingAnimationTime);
			set => SetProperty(ref _liftingAnimationTime, value);
		}

		[Ordinal(2)] 
		[RED("hasDistractionQuickhack")] 
		public CBool HasDistractionQuickhack
		{
			get => GetProperty(ref _hasDistractionQuickhack);
			set => SetProperty(ref _hasDistractionQuickhack, value);
		}
	}
}
