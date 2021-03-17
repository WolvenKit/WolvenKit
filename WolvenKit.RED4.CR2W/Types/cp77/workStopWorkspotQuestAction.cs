using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workStopWorkspotQuestAction : workIWorkspotQuestAction
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

		public workStopWorkspotQuestAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
