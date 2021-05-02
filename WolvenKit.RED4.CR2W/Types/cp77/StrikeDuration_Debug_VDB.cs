using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StrikeDuration_Debug_VDB : StrikeDuration_Debug
	{
		private CFloat _uPDATE_DELAY;
		private CFloat _dISPLAY_DURATION;
		private CFloat _timeToNextUpdate;

		[Ordinal(0)] 
		[RED("UPDATE_DELAY")] 
		public CFloat UPDATE_DELAY
		{
			get => GetProperty(ref _uPDATE_DELAY);
			set => SetProperty(ref _uPDATE_DELAY, value);
		}

		[Ordinal(1)] 
		[RED("DISPLAY_DURATION")] 
		public CFloat DISPLAY_DURATION
		{
			get => GetProperty(ref _dISPLAY_DURATION);
			set => SetProperty(ref _dISPLAY_DURATION, value);
		}

		[Ordinal(2)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get => GetProperty(ref _timeToNextUpdate);
			set => SetProperty(ref _timeToNextUpdate, value);
		}

		public StrikeDuration_Debug_VDB(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
