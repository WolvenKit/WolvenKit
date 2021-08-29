using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameReplAnimTransformSkipRequest : gameReplAnimTransformRequestBase
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
	}
}
