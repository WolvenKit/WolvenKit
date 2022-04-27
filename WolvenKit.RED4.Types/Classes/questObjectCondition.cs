using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questObjectCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIObjectConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIObjectConditionType>>();
			set => SetPropertyValue<CHandle<questIObjectConditionType>>(value);
		}

		public questObjectCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
