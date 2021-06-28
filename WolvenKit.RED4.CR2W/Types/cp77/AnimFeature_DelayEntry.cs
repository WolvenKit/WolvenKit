using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DelayEntry : animAnimFeature
	{
		private CBool _thresholdPassed;

		[Ordinal(0)] 
		[RED("thresholdPassed")] 
		public CBool ThresholdPassed
		{
			get => GetProperty(ref _thresholdPassed);
			set => SetProperty(ref _thresholdPassed, value);
		}

		public AnimFeature_DelayEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
