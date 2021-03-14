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
			get
			{
				if (_slot == null)
				{
					_slot = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "slot", cr2w, this);
				}
				return _slot;
			}
			set
			{
				if (_slot == value)
				{
					return;
				}
				_slot = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSlotOccupiedConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
