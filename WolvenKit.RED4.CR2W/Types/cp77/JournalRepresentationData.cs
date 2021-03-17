using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalRepresentationData : ListItemData
	{
		private wCHandle<gameJournalEntry> _data;
		private wCHandle<gameJournalOnscreensStructuredGroup> _onscreenData;
		private wCHandle<inkWidget> _reference;
		private CBool _isNew;

		[Ordinal(1)] 
		[RED("Data")] 
		public wCHandle<gameJournalEntry> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("OnscreenData")] 
		public wCHandle<gameJournalOnscreensStructuredGroup> OnscreenData
		{
			get => GetProperty(ref _onscreenData);
			set => SetProperty(ref _onscreenData, value);
		}

		[Ordinal(3)] 
		[RED("Reference")] 
		public wCHandle<inkWidget> Reference
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

		public JournalRepresentationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
