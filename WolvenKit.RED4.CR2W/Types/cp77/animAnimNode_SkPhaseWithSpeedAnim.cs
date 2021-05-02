using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseWithSpeedAnim : animAnimNode_SkPhaseAnim
	{
		private animFloatLink _speedLink;

		[Ordinal(31)] 
		[RED("speedLink")] 
		public animFloatLink SpeedLink
		{
			get => GetProperty(ref _speedLink);
			set => SetProperty(ref _speedLink, value);
		}

		public animAnimNode_SkPhaseWithSpeedAnim(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
