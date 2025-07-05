using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestlListItemSelected : redEvent
	{
		[Ordinal(0)] 
		[RED("questData")] 
		public CWeakHandle<gameJournalQuest> QuestData
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(1)] 
		[RED("skipAnimation")] 
		public CBool SkipAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("selectionIndex")] 
		public CUInt32 SelectionIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public QuestlListItemSelected()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
