using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnTalkOnReturn_Operation : scnIInterruptManager_Operation
	{
		[Ordinal(0)] 
		[RED("talkOnReturn")] 
		public CBool TalkOnReturn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
