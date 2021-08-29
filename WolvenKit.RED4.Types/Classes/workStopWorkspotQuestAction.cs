using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workStopWorkspotQuestAction : workIWorkspotQuestAction
	{
		private CBool _allowCurrAnimToFinish;
		private CName _exitAnim;

		[Ordinal(0)] 
		[RED("allowCurrAnimToFinish")] 
		public CBool AllowCurrAnimToFinish
		{
			get => GetProperty(ref _allowCurrAnimToFinish);
			set => SetProperty(ref _allowCurrAnimToFinish, value);
		}

		[Ordinal(1)] 
		[RED("exitAnim")] 
		public CName ExitAnim
		{
			get => GetProperty(ref _exitAnim);
			set => SetProperty(ref _exitAnim, value);
		}
	}
}
