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
			get
			{
				if (_slotId == null)
				{
					_slotId = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CHandle<AIArgumentMapping> Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionUnequipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
