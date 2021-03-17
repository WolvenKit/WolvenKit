using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseWithDurationAnim : animAnimNode_SkPhaseAnim
	{
		private animFloatLink _durationLink;

		[Ordinal(31)] 
		[RED("durationLink")] 
		public animFloatLink DurationLink
		{
			get => GetProperty(ref _durationLink);
			set => SetProperty(ref _durationLink, value);
		}

		public animAnimNode_SkPhaseWithDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
