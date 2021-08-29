using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JournalRepresentationData : ListItemData
	{
		private CWeakHandle<gameJournalEntry> _data;
		private CWeakHandle<gameJournalOnscreensStructuredGroup> _onscreenData;
		private CWeakHandle<inkWidget> _reference;
		private CBool _isNew;

		[Ordinal(1)] 
		[RED("Data")] 
		public CWeakHandle<gameJournalEntry> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("OnscreenData")] 
		public CWeakHandle<gameJournalOnscreensStructuredGroup> OnscreenData
		{
			get => GetProperty(ref _onscreenData);
			set => SetProperty(ref _onscreenData, value);
		}

		[Ordinal(3)] 
		[RED("Reference")] 
		public CWeakHandle<inkWidget> Reference
		{
			get => GetProperty(ref _reference);
			set => SetProperty(ref _reference, value);
		}

		[Ordinal(4)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}
	}
}
