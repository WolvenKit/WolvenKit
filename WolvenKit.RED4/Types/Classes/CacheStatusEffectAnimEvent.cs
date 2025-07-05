using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CacheStatusEffectAnimEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("removeCachedStatusEffect")] 
		public CBool RemoveCachedStatusEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CacheStatusEffectAnimEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
