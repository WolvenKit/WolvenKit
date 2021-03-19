using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformSkipRequest : gameReplAnimTransformRequestBase
	{
		private CName _animName;
		private CFloat _skipTime;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(2)] 
		[RED("skipTime")] 
		public CFloat SkipTime
		{
			get => GetProperty(ref _skipTime);
			set => SetProperty(ref _skipTime, value);
		}

		public gameReplAnimTransformSkipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
