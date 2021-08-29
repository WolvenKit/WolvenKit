using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningComponentPS : gameComponentPS
	{
		private CEnum<gameScanningState> _scanningState;
		private CFloat _pctScanned;
		private CBool _isBlocked;
		private CArray<CHandle<CluePSData>> _storedClues;
		private CBool _isScanningDisabled;
		private CBool _isDecriptionEnabled;
		private CHandle<ObjectScanningDescription> _objectDescriptionOverride;

		[Ordinal(0)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get => GetProperty(ref _scanningState);
			set => SetProperty(ref _scanningState, value);
		}

		[Ordinal(1)] 
		[RED("pctScanned")] 
		public CFloat PctScanned
		{
			get => GetProperty(ref _pctScanned);
			set => SetProperty(ref _pctScanned, value);
		}

		[Ordinal(2)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetProperty(ref _isBlocked);
			set => SetProperty(ref _isBlocked, value);
		}

		[Ordinal(3)] 
		[RED("storedClues")] 
		public CArray<CHandle<CluePSData>> StoredClues
		{
			get => GetProperty(ref _storedClues);
			set => SetProperty(ref _storedClues, value);
		}

		[Ordinal(4)] 
		[RED("isScanningDisabled")] 
		public CBool IsScanningDisabled
		{
			get => GetProperty(ref _isScanningDisabled);
			set => SetProperty(ref _isScanningDisabled, value);
		}

		[Ordinal(5)] 
		[RED("isDecriptionEnabled")] 
		public CBool IsDecriptionEnabled
		{
			get => GetProperty(ref _isDecriptionEnabled);
			set => SetProperty(ref _isDecriptionEnabled, value);
		}

		[Ordinal(6)] 
		[RED("objectDescriptionOverride")] 
		public CHandle<ObjectScanningDescription> ObjectDescriptionOverride
		{
			get => GetProperty(ref _objectDescriptionOverride);
			set => SetProperty(ref _objectDescriptionOverride, value);
		}
	}
}
