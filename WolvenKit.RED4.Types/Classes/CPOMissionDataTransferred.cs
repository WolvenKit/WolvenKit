using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CPOMissionDataTransferred : redEvent
	{
		private CBool _dataDownloaded;
		private CName _dataDamagesPresetName;
		private CName _compatibleDeviceName;
		private CBool _ownerDecidesOnTransfer;
		private CBool _isChoiceToken;
		private CUInt32 _choiceTokenTimeout;

		[Ordinal(0)] 
		[RED("dataDownloaded")] 
		public CBool DataDownloaded
		{
			get => GetProperty(ref _dataDownloaded);
			set => SetProperty(ref _dataDownloaded, value);
		}

		[Ordinal(1)] 
		[RED("dataDamagesPresetName")] 
		public CName DataDamagesPresetName
		{
			get => GetProperty(ref _dataDamagesPresetName);
			set => SetProperty(ref _dataDamagesPresetName, value);
		}

		[Ordinal(2)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get => GetProperty(ref _compatibleDeviceName);
			set => SetProperty(ref _compatibleDeviceName, value);
		}

		[Ordinal(3)] 
		[RED("ownerDecidesOnTransfer")] 
		public CBool OwnerDecidesOnTransfer
		{
			get => GetProperty(ref _ownerDecidesOnTransfer);
			set => SetProperty(ref _ownerDecidesOnTransfer, value);
		}

		[Ordinal(4)] 
		[RED("isChoiceToken")] 
		public CBool IsChoiceToken
		{
			get => GetProperty(ref _isChoiceToken);
			set => SetProperty(ref _isChoiceToken, value);
		}

		[Ordinal(5)] 
		[RED("choiceTokenTimeout")] 
		public CUInt32 ChoiceTokenTimeout
		{
			get => GetProperty(ref _choiceTokenTimeout);
			set => SetProperty(ref _choiceTokenTimeout, value);
		}

		public CPOMissionDataTransferred()
		{
			_dataDamagesPresetName = "CPODataRaceParams";
		}
	}
}
