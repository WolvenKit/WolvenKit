using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerDelayedReactionEvent : DelayedCrowdReactionEvent
	{
		private CBool _initAnim;
		private CEnum<gamedataOutput> _behavior;

		[Ordinal(2)] 
		[RED("initAnim")] 
		public CBool InitAnim
		{
			get => GetProperty(ref _initAnim);
			set => SetProperty(ref _initAnim, value);
		}

		[Ordinal(3)] 
		[RED("behavior")] 
		public CEnum<gamedataOutput> Behavior
		{
			get => GetProperty(ref _behavior);
			set => SetProperty(ref _behavior, value);
		}

		public TriggerDelayedReactionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
