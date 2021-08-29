using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetworkAreaControllerPS : MasterControllerPS
	{
		private CBool _isActive;
		private CUInt32 _visualizerID;
		private CBool _hudActivated;
		private CInt32 _currentlyAvailableCharges;
		private CInt32 _maxAvailableCharges;

		[Ordinal(105)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(106)] 
		[RED("visualizerID")] 
		public CUInt32 VisualizerID
		{
			get => GetProperty(ref _visualizerID);
			set => SetProperty(ref _visualizerID, value);
		}

		[Ordinal(107)] 
		[RED("hudActivated")] 
		public CBool HudActivated
		{
			get => GetProperty(ref _hudActivated);
			set => SetProperty(ref _hudActivated, value);
		}

		[Ordinal(108)] 
		[RED("currentlyAvailableCharges")] 
		public CInt32 CurrentlyAvailableCharges
		{
			get => GetProperty(ref _currentlyAvailableCharges);
			set => SetProperty(ref _currentlyAvailableCharges, value);
		}

		[Ordinal(109)] 
		[RED("maxAvailableCharges")] 
		public CInt32 MaxAvailableCharges
		{
			get => GetProperty(ref _maxAvailableCharges);
			set => SetProperty(ref _maxAvailableCharges, value);
		}
	}
}
