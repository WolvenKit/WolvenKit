using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnTalkOnReturn_Operation : scnIInterruptManager_Operation
	{
		private CBool _talkOnReturn;

		[Ordinal(0)] 
		[RED("talkOnReturn")] 
		public CBool TalkOnReturn
		{
			get => GetProperty(ref _talkOnReturn);
			set => SetProperty(ref _talkOnReturn, value);
		}
	}
}
