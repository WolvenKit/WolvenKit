using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnLookAtBasicEventData : RedBaseClass
	{
		private scnAnimTargetBasicData _basic;
		private CBool _removePreviousAdvancedLookAts;
		private CArray<animLookAtRequestForPart> _requests;

		[Ordinal(0)] 
		[RED("basic")] 
		public scnAnimTargetBasicData Basic
		{
			get => GetProperty(ref _basic);
			set => SetProperty(ref _basic, value);
		}

		[Ordinal(1)] 
		[RED("removePreviousAdvancedLookAts")] 
		public CBool RemovePreviousAdvancedLookAts
		{
			get => GetProperty(ref _removePreviousAdvancedLookAts);
			set => SetProperty(ref _removePreviousAdvancedLookAts, value);
		}

		[Ordinal(2)] 
		[RED("requests")] 
		public CArray<animLookAtRequestForPart> Requests
		{
			get => GetProperty(ref _requests);
			set => SetProperty(ref _requests, value);
		}

		public scnLookAtBasicEventData()
		{
			_removePreviousAdvancedLookAts = true;
		}
	}
}
