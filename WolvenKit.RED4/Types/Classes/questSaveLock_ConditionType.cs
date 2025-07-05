using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSaveLock_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSaveLock_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
