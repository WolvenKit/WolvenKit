using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LinkedFocusClueData : RedBaseClass
	{
		private CName _clueGroupID;
		private entEntityID _ownerID;
		private CInt32 _clueIndex;
		private TweakDBID _clueRecord;
		private CArray<ClueRecordData> _extendedClueRecords;
		private CBool _isScanned;
		private CBool _wasInspected;
		private CBool _isEnabled;
		private PSOwnerData _psData;

		[Ordinal(0)] 
		[RED("clueGroupID")] 
		public CName ClueGroupID
		{
			get => GetProperty(ref _clueGroupID);
			set => SetProperty(ref _clueGroupID, value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(2)] 
		[RED("clueIndex")] 
		public CInt32 ClueIndex
		{
			get => GetProperty(ref _clueIndex);
			set => SetProperty(ref _clueIndex, value);
		}

		[Ordinal(3)] 
		[RED("clueRecord")] 
		public TweakDBID ClueRecord
		{
			get => GetProperty(ref _clueRecord);
			set => SetProperty(ref _clueRecord, value);
		}

		[Ordinal(4)] 
		[RED("extendedClueRecords")] 
		public CArray<ClueRecordData> ExtendedClueRecords
		{
			get => GetProperty(ref _extendedClueRecords);
			set => SetProperty(ref _extendedClueRecords, value);
		}

		[Ordinal(5)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetProperty(ref _isScanned);
			set => SetProperty(ref _isScanned, value);
		}

		[Ordinal(6)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get => GetProperty(ref _wasInspected);
			set => SetProperty(ref _wasInspected, value);
		}

		[Ordinal(7)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(8)] 
		[RED("psData")] 
		public PSOwnerData PsData
		{
			get => GetProperty(ref _psData);
			set => SetProperty(ref _psData, value);
		}
	}
}
