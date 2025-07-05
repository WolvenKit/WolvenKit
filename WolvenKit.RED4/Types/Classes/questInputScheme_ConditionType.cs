using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInputScheme_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("scheme")] 
		public CEnum<questInputScheme> Scheme
		{
			get => GetPropertyValue<CEnum<questInputScheme>>();
			set => SetPropertyValue<CEnum<questInputScheme>>(value);
		}

		public questInputScheme_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
