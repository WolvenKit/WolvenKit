using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkFrameAnim : animAnimNode_SkAnim
	{
		private animFloatLink _progressLink;
		private animFloatLink _timeLink;
		private animFloatLink _frameLink;
		private CBool _fireAnimEndOnceOnAnimEnd;

		[Ordinal(30)] 
		[RED("progressLink")] 
		public animFloatLink ProgressLink
		{
			get => GetProperty(ref _progressLink);
			set => SetProperty(ref _progressLink, value);
		}

		[Ordinal(31)] 
		[RED("timeLink")] 
		public animFloatLink TimeLink
		{
			get => GetProperty(ref _timeLink);
			set => SetProperty(ref _timeLink, value);
		}

		[Ordinal(32)] 
		[RED("frameLink")] 
		public animFloatLink FrameLink
		{
			get => GetProperty(ref _frameLink);
			set => SetProperty(ref _frameLink, value);
		}

		[Ordinal(33)] 
		[RED("fireAnimEndOnceOnAnimEnd")] 
		public CBool FireAnimEndOnceOnAnimEnd
		{
			get => GetProperty(ref _fireAnimEndOnceOnAnimEnd);
			set => SetProperty(ref _fireAnimEndOnceOnAnimEnd, value);
		}

		public animAnimNode_SkFrameAnim(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
