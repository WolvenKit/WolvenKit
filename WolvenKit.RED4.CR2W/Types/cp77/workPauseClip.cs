using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workPauseClip : workIEntry
	{
		private CFloat _timeMin;
		private CFloat _timeMax;
		private CFloat _blendOutTime;

		[Ordinal(2)] 
		[RED("timeMin")] 
		public CFloat TimeMin
		{
			get => GetProperty(ref _timeMin);
			set => SetProperty(ref _timeMin, value);
		}

		[Ordinal(3)] 
		[RED("timeMax")] 
		public CFloat TimeMax
		{
			get => GetProperty(ref _timeMax);
			set => SetProperty(ref _timeMax, value);
		}

		[Ordinal(4)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetProperty(ref _blendOutTime);
			set => SetProperty(ref _blendOutTime, value);
		}

		public workPauseClip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
