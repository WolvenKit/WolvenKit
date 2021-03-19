using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_GameplayVo : animAnimEvent
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

		public animAnimEvent_GameplayVo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
