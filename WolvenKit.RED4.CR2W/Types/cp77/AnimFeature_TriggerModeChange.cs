using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_TriggerModeChange : animAnimFeature
	{
		private CFloat _cycleTime;

		[Ordinal(0)] 
		[RED("cycleTime")] 
		public CFloat CycleTime
		{
			get => GetProperty(ref _cycleTime);
			set => SetProperty(ref _cycleTime, value);
		}

		public AnimFeature_TriggerModeChange(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
