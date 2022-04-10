using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FocusClueDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("extendedClueRecords")] 
		public CArray<ClueRecordData> ExtendedClueRecords
		{
			get => GetPropertyValue<CArray<ClueRecordData>>();
			set => SetPropertyValue<CArray<ClueRecordData>>(value);
		}

		[Ordinal(1)] 
		[RED("clueRecord")] 
		public TweakDBID ClueRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("factToActivate")] 
		public CName FactToActivate
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get => GetPropertyValue<CArray<SFactOperationData>>();
			set => SetPropertyValue<CArray<SFactOperationData>>(value);
		}

		[Ordinal(4)] 
		[RED("useAutoInspect")] 
		public CBool UseAutoInspect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isProgressing")] 
		public CBool IsProgressing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("clueGroupID")] 
		public CName ClueGroupID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("qDbCallbackID")] 
		public CUInt32 QDbCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("conclusionQuestState")] 
		public CEnum<EConclusionQuestState> ConclusionQuestState
		{
			get => GetPropertyValue<CEnum<EConclusionQuestState>>();
			set => SetPropertyValue<CEnum<EConclusionQuestState>>(value);
		}

		public FocusClueDefinition()
		{
			ExtendedClueRecords = new();
			Facts = new();
			IsProgressing = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
