using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRecordSelector : ISerializable
	{
		private CBool _isCharacter;
		private TweakDBID _characterRecordID;
		private CBool _isDevice;
		private TweakDBID _deviceRecordID;
		private CBool _isItem;
		private TweakDBID _itemRecordID;

		[Ordinal(0)] 
		[RED("isCharacter")] 
		public CBool IsCharacter
		{
			get => GetProperty(ref _isCharacter);
			set => SetProperty(ref _isCharacter, value);
		}

		[Ordinal(1)] 
		[RED("characterRecordID")] 
		public TweakDBID CharacterRecordID
		{
			get => GetProperty(ref _characterRecordID);
			set => SetProperty(ref _characterRecordID, value);
		}

		[Ordinal(2)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get => GetProperty(ref _isDevice);
			set => SetProperty(ref _isDevice, value);
		}

		[Ordinal(3)] 
		[RED("deviceRecordID")] 
		public TweakDBID DeviceRecordID
		{
			get => GetProperty(ref _deviceRecordID);
			set => SetProperty(ref _deviceRecordID, value);
		}

		[Ordinal(4)] 
		[RED("isItem")] 
		public CBool IsItem
		{
			get => GetProperty(ref _isItem);
			set => SetProperty(ref _isItem, value);
		}

		[Ordinal(5)] 
		[RED("itemRecordID")] 
		public TweakDBID ItemRecordID
		{
			get => GetProperty(ref _itemRecordID);
			set => SetProperty(ref _itemRecordID, value);
		}

		public questRecordSelector()
		{
			_isCharacter = true;
		}
	}
}
