using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeakspotRequestAttributeChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("blockDamage")] 
		public CBool BlockDamage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("blockHighlight")] 
		public CBool BlockHighlight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WeakspotRequestAttributeChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
