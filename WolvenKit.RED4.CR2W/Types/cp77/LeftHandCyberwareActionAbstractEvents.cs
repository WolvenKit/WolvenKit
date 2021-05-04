using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareActionAbstractEvents : LeftHandCyberwareEventsTransition
	{
		private CBool _projectileReleased;

		[Ordinal(0)] 
		[RED("projectileReleased")] 
		public CBool ProjectileReleased
		{
			get => GetProperty(ref _projectileReleased);
			set => SetProperty(ref _projectileReleased, value);
		}

		public LeftHandCyberwareActionAbstractEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
