using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalMetaQuestScriptedData : RedBaseClass
	{
		private CUInt32 _percent;
		private CBool _hidden;
		private CString _text;

		[Ordinal(0)] 
		[RED("percent")] 
		public CUInt32 Percent
		{
			get => GetProperty(ref _percent);
			set => SetProperty(ref _percent, value);
		}

		[Ordinal(1)] 
		[RED("hidden")] 
		public CBool Hidden
		{
			get => GetProperty(ref _hidden);
			set => SetProperty(ref _hidden, value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		public gameJournalMetaQuestScriptedData()
		{
			_hidden = true;
		}
	}
}
