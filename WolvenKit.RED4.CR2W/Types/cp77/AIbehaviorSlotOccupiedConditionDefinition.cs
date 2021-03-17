using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSlotOccupiedConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _slot;

		[Ordinal(1)] 
		[RED("slot")] 
		public CHandle<AIArgumentMapping> Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}

		public AIbehaviorSlotOccupiedConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
