using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SCodexRecord : RedBaseClass
	{
		private TweakDBID _recordID;
		private CArray<SCodexRecordPart> _recordContent;
		private CArray<CName> _tags;
		private CBool _unlocked;

		[Ordinal(0)] 
		[RED("RecordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(1)] 
		[RED("RecordContent")] 
		public CArray<SCodexRecordPart> RecordContent
		{
			get => GetProperty(ref _recordContent);
			set => SetProperty(ref _recordContent, value);
		}

		[Ordinal(2)] 
		[RED("Tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(3)] 
		[RED("Unlocked")] 
		public CBool Unlocked
		{
			get => GetProperty(ref _unlocked);
			set => SetProperty(ref _unlocked, value);
		}
	}
}
