using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FocusClueDefinition : RedBaseClass
	{
		private CArray<ClueRecordData> _extendedClueRecords;
		private TweakDBID _clueRecord;
		private CName _factToActivate;
		private CArray<SFactOperationData> _facts;
		private CBool _useAutoInspect;
		private CBool _isEnabled;
		private CBool _isProgressing;
		private CName _clueGroupID;
		private CBool _wasInspected;
		private CUInt32 _qDbCallbackID;
		private CEnum<EConclusionQuestState> _conclusionQuestState;

		[Ordinal(0)] 
		[RED("extendedClueRecords")] 
		public CArray<ClueRecordData> ExtendedClueRecords
		{
			get => GetProperty(ref _extendedClueRecords);
			set => SetProperty(ref _extendedClueRecords, value);
		}

		[Ordinal(1)] 
		[RED("clueRecord")] 
		public TweakDBID ClueRecord
		{
			get => GetProperty(ref _clueRecord);
			set => SetProperty(ref _clueRecord, value);
		}

		[Ordinal(2)] 
		[RED("factToActivate")] 
		public CName FactToActivate
		{
			get => GetProperty(ref _factToActivate);
			set => SetProperty(ref _factToActivate, value);
		}

		[Ordinal(3)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get => GetProperty(ref _facts);
			set => SetProperty(ref _facts, value);
		}

		[Ordinal(4)] 
		[RED("useAutoInspect")] 
		public CBool UseAutoInspect
		{
			get => GetProperty(ref _useAutoInspect);
			set => SetProperty(ref _useAutoInspect, value);
		}

		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(6)] 
		[RED("isProgressing")] 
		public CBool IsProgressing
		{
			get => GetProperty(ref _isProgressing);
			set => SetProperty(ref _isProgressing, value);
		}

		[Ordinal(7)] 
		[RED("clueGroupID")] 
		public CName ClueGroupID
		{
			get => GetProperty(ref _clueGroupID);
			set => SetProperty(ref _clueGroupID, value);
		}

		[Ordinal(8)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get => GetProperty(ref _wasInspected);
			set => SetProperty(ref _wasInspected, value);
		}

		[Ordinal(9)] 
		[RED("qDbCallbackID")] 
		public CUInt32 QDbCallbackID
		{
			get => GetProperty(ref _qDbCallbackID);
			set => SetProperty(ref _qDbCallbackID, value);
		}

		[Ordinal(10)] 
		[RED("conclusionQuestState")] 
		public CEnum<EConclusionQuestState> ConclusionQuestState
		{
			get => GetProperty(ref _conclusionQuestState);
			set => SetProperty(ref _conclusionQuestState, value);
		}

		public FocusClueDefinition()
		{
			_isProgressing = true;
		}
	}
}
