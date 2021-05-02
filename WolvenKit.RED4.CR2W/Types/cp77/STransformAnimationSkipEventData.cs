using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STransformAnimationSkipEventData : CVariable
	{
		private CFloat _time;
		private CBool _skipToEnd;

		[Ordinal(0)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(1)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get => GetProperty(ref _skipToEnd);
			set => SetProperty(ref _skipToEnd, value);
		}

		public STransformAnimationSkipEventData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
