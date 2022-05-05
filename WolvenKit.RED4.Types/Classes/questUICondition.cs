using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUICondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIUIConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIUIConditionType>>();
			set => SetPropertyValue<CHandle<questIUIConditionType>>(value);
		}

		public questUICondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
