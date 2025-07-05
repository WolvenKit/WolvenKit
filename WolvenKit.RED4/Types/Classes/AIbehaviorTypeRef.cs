using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorTypeRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isSet")] 
		public CBool IsSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("customType")] 
		public CName CustomType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("enumeratedType")] 
		public CEnum<AIArgumentType> EnumeratedType
		{
			get => GetPropertyValue<CEnum<AIArgumentType>>();
			set => SetPropertyValue<CEnum<AIArgumentType>>(value);
		}

		public AIbehaviorTypeRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
