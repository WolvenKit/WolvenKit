using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectDuration_PredefinedTimeout : gameEffectDurationModifier
	{
		private CFloat _timeToLive;

		[Ordinal(0)] 
		[RED("timeToLive")] 
		public CFloat TimeToLive
		{
			get => GetProperty(ref _timeToLive);
			set => SetProperty(ref _timeToLive, value);
		}

		public gameEffectDuration_PredefinedTimeout(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
