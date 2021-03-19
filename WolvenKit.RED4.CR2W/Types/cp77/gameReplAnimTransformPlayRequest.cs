using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformPlayRequest : gameReplAnimTransformRequestBase
	{
		private CName _animName;
		private CFloat _timeScale;
		private CInt32 _timesToPlay;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(2)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetProperty(ref _timeScale);
			set => SetProperty(ref _timeScale, value);
		}

		[Ordinal(3)] 
		[RED("timesToPlay")] 
		public CInt32 TimesToPlay
		{
			get => GetProperty(ref _timesToPlay);
			set => SetProperty(ref _timesToPlay, value);
		}

		public gameReplAnimTransformPlayRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
