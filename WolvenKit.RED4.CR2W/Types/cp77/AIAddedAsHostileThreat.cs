using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAddedAsHostileThreat : AIAIEvent
	{
		private wCHandle<AITargetTrackerComponent> _threateningEntity;
		private CBool _threateningEntityCanTriggersCombat;

		[Ordinal(2)] 
		[RED("threateningEntity")] 
		public wCHandle<AITargetTrackerComponent> ThreateningEntity
		{
			get => GetProperty(ref _threateningEntity);
			set => SetProperty(ref _threateningEntity, value);
		}

		[Ordinal(3)] 
		[RED("threateningEntityCanTriggersCombat")] 
		public CBool ThreateningEntityCanTriggersCombat
		{
			get => GetProperty(ref _threateningEntityCanTriggersCombat);
			set => SetProperty(ref _threateningEntityCanTriggersCombat, value);
		}

		public AIAddedAsHostileThreat(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
