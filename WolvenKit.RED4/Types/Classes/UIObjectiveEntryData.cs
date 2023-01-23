using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIObjectiveEntryData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("counter")] 
		public CString Counter
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<UIObjectiveEntryType> Type
		{
			get => GetPropertyValue<CEnum<UIObjectiveEntryType>>();
			set => SetPropertyValue<CEnum<UIObjectiveEntryType>>(value);
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<gameJournalEntryState> State
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(4)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isOptional")] 
		public CBool IsOptional
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UIObjectiveEntryData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
