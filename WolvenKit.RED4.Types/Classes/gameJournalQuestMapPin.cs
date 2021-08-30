using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestMapPin : gameJournalQuestMapPinBase
	{
		private gameEntityReference _reference;
		private CName _slotName;
		private gamemappinsMappinData _mappinData;
		private Vector3 _offset;
		private TweakDBID _uiAnimation;

		[Ordinal(3)] 
		[RED("reference")] 
		public gameEntityReference Reference
		{
			get => GetProperty(ref _reference);
			set => SetProperty(ref _reference, value);
		}

		[Ordinal(4)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(5)] 
		[RED("mappinData")] 
		public gamemappinsMappinData MappinData
		{
			get => GetProperty(ref _mappinData);
			set => SetProperty(ref _mappinData, value);
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(7)] 
		[RED("uiAnimation")] 
		public TweakDBID UiAnimation
		{
			get => GetProperty(ref _uiAnimation);
			set => SetProperty(ref _uiAnimation, value);
		}

		public gameJournalQuestMapPin()
		{
			_slotName = "UI_Interaction";
		}
	}
}
