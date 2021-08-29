using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CPOMissionDataAccessPoint : CPOMissionDevice
	{
		private CBool _hasDataToDownload;
		private CName _damagesPresetName;
		private CArray<SFactToChange> _factsOnDownload;
		private CArray<SFactToChange> _factsOnUpload;
		private CBool _ownerDecidesOnTransfer;

		[Ordinal(45)] 
		[RED("hasDataToDownload")] 
		public CBool HasDataToDownload
		{
			get => GetProperty(ref _hasDataToDownload);
			set => SetProperty(ref _hasDataToDownload, value);
		}

		[Ordinal(46)] 
		[RED("damagesPresetName")] 
		public CName DamagesPresetName
		{
			get => GetProperty(ref _damagesPresetName);
			set => SetProperty(ref _damagesPresetName, value);
		}

		[Ordinal(47)] 
		[RED("factsOnDownload")] 
		public CArray<SFactToChange> FactsOnDownload
		{
			get => GetProperty(ref _factsOnDownload);
			set => SetProperty(ref _factsOnDownload, value);
		}

		[Ordinal(48)] 
		[RED("factsOnUpload")] 
		public CArray<SFactToChange> FactsOnUpload
		{
			get => GetProperty(ref _factsOnUpload);
			set => SetProperty(ref _factsOnUpload, value);
		}

		[Ordinal(49)] 
		[RED("ownerDecidesOnTransfer")] 
		public CBool OwnerDecidesOnTransfer
		{
			get => GetProperty(ref _ownerDecidesOnTransfer);
			set => SetProperty(ref _ownerDecidesOnTransfer, value);
		}
	}
}
