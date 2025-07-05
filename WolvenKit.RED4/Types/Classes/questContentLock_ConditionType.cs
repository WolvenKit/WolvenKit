using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questContentLock_ConditionType : questIContentConditionType
	{
		[Ordinal(0)] 
		[RED("isContentBlocked")] 
		public CBool IsContentBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questContentLock_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
