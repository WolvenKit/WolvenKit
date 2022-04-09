using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorCheckLineOfFireTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("slotName")] 
		public CHandle<AIArgumentMapping> SlotName
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("attachmentName")] 
		public CHandle<AIArgumentMapping> AttachmentName
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("spread")] 
		public CHandle<AIArgumentMapping> Spread
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("maxRange")] 
		public CHandle<AIArgumentMapping> MaxRange
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorCheckLineOfFireTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
