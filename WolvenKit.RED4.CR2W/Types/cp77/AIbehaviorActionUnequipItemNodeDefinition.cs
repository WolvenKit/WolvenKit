using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionUnequipItemNodeDefinition : AIbehaviorActionItemHandlingNodeDefinition
	{
		private CHandle<AIArgumentMapping> _slotId;
		private CHandle<AIArgumentMapping> _duration;

		[Ordinal(1)] 
		[RED("slotId")] 
		public CHandle<AIArgumentMapping> SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CHandle<AIArgumentMapping> Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public AIbehaviorActionUnequipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
