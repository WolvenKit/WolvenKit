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
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(2)] 
		[RED("attachmentName")] 
		public CHandle<AIArgumentMapping> AttachmentName
		{
			get => GetProperty(ref _attachmentName);
			set => SetProperty(ref _attachmentName, value);
		}

		[Ordinal(3)] 
		[RED("spread")] 
		public CHandle<AIArgumentMapping> Spread
		{
			get => GetProperty(ref _spread);
			set => SetProperty(ref _spread, value);
		}

		[Ordinal(4)] 
		[RED("maxRange")] 
		public CHandle<AIArgumentMapping> MaxRange
		{
			get => GetProperty(ref _maxRange);
			set => SetProperty(ref _maxRange, value);
		}

		public AIbehaviorCheckLineOfFireTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
