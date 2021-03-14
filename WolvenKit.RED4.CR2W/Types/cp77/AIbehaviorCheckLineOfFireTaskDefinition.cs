using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCheckLineOfFireTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _slotName;
		private CHandle<AIArgumentMapping> _attachmentName;
		private CHandle<AIArgumentMapping> _spread;
		private CHandle<AIArgumentMapping> _maxRange;

		[Ordinal(1)] 
		[RED("slotName")] 
		public CHandle<AIArgumentMapping> SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("attachmentName")] 
		public CHandle<AIArgumentMapping> AttachmentName
		{
			get
			{
				if (_attachmentName == null)
				{
					_attachmentName = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "attachmentName", cr2w, this);
				}
				return _attachmentName;
			}
			set
			{
				if (_attachmentName == value)
				{
					return;
				}
				_attachmentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("spread")] 
		public CHandle<AIArgumentMapping> Spread
		{
			get
			{
				if (_spread == null)
				{
					_spread = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "spread", cr2w, this);
				}
				return _spread;
			}
			set
			{
				if (_spread == value)
				{
					return;
				}
				_spread = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxRange")] 
		public CHandle<AIArgumentMapping> MaxRange
		{
			get
			{
				if (_maxRange == null)
				{
					_maxRange = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "maxRange", cr2w, this);
				}
				return _maxRange;
			}
			set
			{
				if (_maxRange == value)
				{
					return;
				}
				_maxRange = value;
				PropertySet(this);
			}
		}

		public AIbehaviorCheckLineOfFireTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
