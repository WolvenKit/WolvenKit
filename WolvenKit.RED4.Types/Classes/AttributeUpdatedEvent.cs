using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttributeUpdatedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public AttributeUpdatedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
