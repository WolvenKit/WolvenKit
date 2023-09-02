using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameJournalQuestObjectiveBase : gameJournalContainerEntry
	{
		[Ordinal(2)] 
		[RED("description")] 
		public LocalizationString Description
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(3)] 
		[RED("counter")] 
		public CUInt32 Counter
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("optional")] 
		public CBool Optional
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("locationPrefabRef")] 
		public NodeRef LocationPrefabRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(6)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(7)] 
		[RED("districtID")] 
		public CString DistrictID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameJournalQuestObjectiveBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
