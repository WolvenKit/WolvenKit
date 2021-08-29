using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent_GameplayVo : animAnimEvent
	{
		private CName _voContext;
		private CBool _isQuest;

		[Ordinal(3)] 
		[RED("voContext")] 
		public CName VoContext
		{
			get => GetProperty(ref _voContext);
			set => SetProperty(ref _voContext, value);
		}

		[Ordinal(4)] 
		[RED("isQuest")] 
		public CBool IsQuest
		{
			get => GetProperty(ref _isQuest);
			set => SetProperty(ref _isQuest, value);
		}
	}
}
