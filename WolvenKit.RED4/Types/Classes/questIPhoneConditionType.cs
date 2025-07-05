using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class questIPhoneConditionType : questIUIConditionType
	{
		[Ordinal(0)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questIPhoneConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
