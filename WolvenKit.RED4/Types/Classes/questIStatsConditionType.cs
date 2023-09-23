using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class questIStatsConditionType : questIConditionType
	{
		[Ordinal(0)] 
		[RED("entityRef")] 
		public CHandle<questUniversalRef> EntityRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		public questIStatsConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
