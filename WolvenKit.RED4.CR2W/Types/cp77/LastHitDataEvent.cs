using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LastHitDataEvent : redEvent
	{
		private CHandle<HitReactionBehaviorData> _hitReactionBehaviorData;

		[Ordinal(0)] 
		[RED("hitReactionBehaviorData")] 
		public CHandle<HitReactionBehaviorData> HitReactionBehaviorData
		{
			get => GetProperty(ref _hitReactionBehaviorData);
			set => SetProperty(ref _hitReactionBehaviorData, value);
		}

		public LastHitDataEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
