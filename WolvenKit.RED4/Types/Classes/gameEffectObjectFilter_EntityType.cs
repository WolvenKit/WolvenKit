using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_EntityType : gameEffectObjectGroupFilter
	{
		[Ordinal(0)] 
		[RED("typeFilter")] 
		public CEnum<gameEffectObjectFilter_EntityTypeEntityTypeFilter> TypeFilter
		{
			get => GetPropertyValue<CEnum<gameEffectObjectFilter_EntityTypeEntityTypeFilter>>();
			set => SetPropertyValue<CEnum<gameEffectObjectFilter_EntityTypeEntityTypeFilter>>(value);
		}

		public gameEffectObjectFilter_EntityType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
