using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scannerDataStructure : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityName")] 
		public CString EntityName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("quickHackName")] 
		public CString QuickHackName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("quickHackDesc")] 
		public CString QuickHackDesc
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("questEntries")] 
		public CArray<scannerQuestEntry> QuestEntries
		{
			get => GetPropertyValue<CArray<scannerQuestEntry>>();
			set => SetPropertyValue<CArray<scannerQuestEntry>>(value);
		}

		[Ordinal(4)] 
		[RED("empty")] 
		public CBool Empty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scannerDataStructure()
		{
			QuestEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
