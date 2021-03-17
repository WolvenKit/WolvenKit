using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeathParamsEvent : redEvent
	{
		private CBool _noAnimation;
		private CBool _noRagdoll;

		[Ordinal(0)] 
		[RED("noAnimation")] 
		public CBool NoAnimation
		{
			get => GetProperty(ref _noAnimation);
			set => SetProperty(ref _noAnimation, value);
		}

		[Ordinal(1)] 
		[RED("noRagdoll")] 
		public CBool NoRagdoll
		{
			get => GetProperty(ref _noRagdoll);
			set => SetProperty(ref _noRagdoll, value);
		}

		public gameeventsDeathParamsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
