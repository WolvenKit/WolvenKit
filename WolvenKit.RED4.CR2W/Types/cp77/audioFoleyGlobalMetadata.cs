using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFoleyGlobalMetadata : audioAudioMetadata
	{
		private CFloat _fadeoutTime;
		private CName _fadeoutRtpc;

		[Ordinal(1)] 
		[RED("fadeoutTime")] 
		public CFloat FadeoutTime
		{
			get => GetProperty(ref _fadeoutTime);
			set => SetProperty(ref _fadeoutTime, value);
		}

		[Ordinal(2)] 
		[RED("fadeoutRtpc")] 
		public CName FadeoutRtpc
		{
			get => GetProperty(ref _fadeoutRtpc);
			set => SetProperty(ref _fadeoutRtpc, value);
		}

		public audioFoleyGlobalMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
